using UnityEngine;

namespace MiniGame_MonsterDrrop
{
    public class MD_Peg : MonoBehaviour
    {
        public ParticleSystem onDestoryPS;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            ParticleSystem _onDestroy = Instantiate(onDestoryPS, transform.position, Quaternion.identity);
            Destroy(_onDestroy, 2f);
            Destroy(this.gameObject);
        }
    }
}