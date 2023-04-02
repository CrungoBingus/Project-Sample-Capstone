using UnityEngine;

namespace MiniGame_MonsterDrrop
{
    public class MD_GoalPointsManager : MonoBehaviour
    {
        public int percentHit;

        public GameObject rightHit;
        public GameObject leftHit;
        public GameObject centerHit;

        private void Start()
        {
            Invoke(nameof(BuildPoints), 1f);
        }

        void BuildPoints()
        {
            rightHit.GetComponent<MD_GoalPoint>().value = percentHit;
            leftHit.GetComponent<MD_GoalPoint>().value = percentHit;
            centerHit.GetComponent<MD_GoalPoint>().value = percentHit + 10;
        }
    }
}