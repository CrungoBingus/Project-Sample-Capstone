using UnityEngine;

namespace MiniGame_MonsterDrrop
{
    public class MD_GoalPointsManager : MonoBehaviour
    {
        public int jackpotHit;

        public GameObject rightHit;
        public GameObject leftHit;
        public GameObject centerHit;

        private void Start()
        {
            Invoke(nameof(BuildPoints), 1f);
        }

        void BuildPoints()
        {
            rightHit.GetComponent<MD_GoalPoint>().value = jackpotHit;
            leftHit.GetComponent<MD_GoalPoint>().value = jackpotHit;
            centerHit.GetComponent<MD_GoalPoint>().value = (int)(jackpotHit * 1.5f);
        }
    }
}