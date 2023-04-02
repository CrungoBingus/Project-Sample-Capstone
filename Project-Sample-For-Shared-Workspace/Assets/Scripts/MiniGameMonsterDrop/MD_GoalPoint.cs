using UnityEngine;

using UnityEngine.UI;

using TMPro;

namespace MiniGame_MonsterDrrop
{
    public class MD_GoalPoint : MonoBehaviour
    {
        public SpriteRenderer bgr;

        TextMeshProUGUI _textHolder;
        public int value;

        Color c;

        private void Awake()
        {
            _textHolder = GetComponentInChildren<TextMeshProUGUI>();
        }

        private void Start()
        {
            Invoke(nameof(SetData), 1f);
        }

        void SetData()
        {
            c = Color.Lerp(Color.red, Color.green, value / 100f);

            _textHolder.text = value.ToString() + "%";
            _textHolder.color = c;

            bgr.color = c;
        }
    }
}