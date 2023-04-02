using UnityEngine;

namespace MiniGame_MonsterDrrop
{
    public class MD_GameManager : MonoBehaviour
    {
        [HideInInspector] public Vector2 posToSpawn;

        public int fieldCount = 6;
        public int fieldDistance = 6;

        public int gameCount = 3;
        public int gameDistance = 10;

        public GameObject goal;
        public GameObject endGoal;
        public GameObject[] fields;
        int _index = 0;

        int _percentValue = 50;

        public static MD_GameManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }

            Time.timeScale = 1f;
            Time.fixedDeltaTime = .02f;
        }
        private void Start()
        {
            posToSpawn = new Vector2(0, 0);
            for (int x = 0; x < gameCount; x++)
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    int m_newRand = 0;
                    do
                    {
                        m_newRand = Random.Range(0, fields.Length);
                    } while (m_newRand == _index);
                    _index = m_newRand;

                    posToSpawn = new Vector2(0, posToSpawn.y - fieldDistance);

                    GameObject m_newField = Instantiate(fields[m_newRand], posToSpawn, Quaternion.identity);
                }
                posToSpawn = new Vector2(0, posToSpawn.y - gameDistance);
                GameObject m_goal = Instantiate(goal, posToSpawn, Quaternion.identity);

                m_goal.GetComponent<MD_GoalPointsManager>().percentHit = _percentValue;
                _percentValue += 15;

                posToSpawn = new Vector2(0, posToSpawn.y - fieldDistance);
            }
            posToSpawn = new Vector2(0, posToSpawn.y - gameDistance);
            GameObject m_endGoal = Instantiate(endGoal, posToSpawn, Quaternion.identity);
        }
    }
}