using UnityEngine;

using UnityEngine.UI;

using TMPro;

namespace MiniGame_MonsterDrrop
{
    public class MD_GameEndLogic : MonoBehaviour
    {
        public GameObject endgameUI;
        public TextMeshProUGUI text;

        int _gameResultValue = 0;

        private void Awake()
        {
            endgameUI.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            endgameUI.SetActive(true);

            _gameResultValue = collision.gameObject.GetComponent<MD_GoalPoint>().value;
            text.text = "Jackpot\n----------\n" + _gameResultValue.ToString();

            Time.timeScale = 0.02f;
            Time.fixedDeltaTime = 0.02f;
        }
    }
}