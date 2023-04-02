using UnityEngine;


namespace MiniGame_MonsterDrrop
{
    public class MD_CameraController : MonoBehaviour
    {

        public Transform playerTransform;

        private void LateUpdate()
        {
            if (transform.position.y > playerTransform.position.y &&
                transform.position.y > MD_GameManager.Instance.posToSpawn.y + 10f)
                transform.position = new Vector3(0, playerTransform.position.y, -10f);
        }
    }
}