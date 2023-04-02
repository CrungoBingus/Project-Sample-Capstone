using UnityEngine;


namespace MiniGame_MonsterDrrop
{
    public class MD_Peg3 : MonoBehaviour
    {
        float _rotValue;

        float _rotScale;

        private void Start()
        {
            _rotValue = Random.Range(-360, 360);

            if (_rotValue < 0)
                _rotScale = -60f;
            else _rotScale = 60f;
        }

        private void Update()
        {
            _rotValue += _rotScale * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, _rotValue);
        }
    }
}