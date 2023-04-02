using UnityEngine;

namespace MiniGame_MonsterDrrop
{
    public class MD_DelayStarrtTesting : MonoBehaviour
    {
        Rigidbody2D _rb2d;

        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
            _rb2d.isKinematic = true;

            Invoke(nameof(StartGame), 1.5f);
        }

        void StartGame()
        {
            _rb2d.isKinematic = false;
            _rb2d.AddForce(new Vector2((Random.value - .5f) * 30, (Random.value - .5f) * 5), ForceMode2D.Impulse);
        }
    }
}