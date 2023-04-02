using UnityEngine;


namespace MiniGame_MonsterDrrop
{
    public class MD_PlayerVisuals : MonoBehaviour
    {
        public ParticleSystem onhitParticles;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            ParticleSystem m_onHitParticles = Instantiate(onhitParticles, collision.contacts[0].point,
                Quaternion.LookRotation(collision.contacts[0].normal));
            Destroy(m_onHitParticles, 5f);
        }
    }
}