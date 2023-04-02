using System.Collections;

using UnityEngine;

namespace MiniGame_MonsterDrrop
{
    public class MD_Peg2 : MonoBehaviour
    {
        float scale = 1f;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            StartCoroutine(nameof(Pop));
        }

        IEnumerator Pop()
        {
            scale = 2f;
            while (scale > 1f)
            {
                transform.localScale = new Vector2(scale, scale);
                scale -= Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

        }
    }
}