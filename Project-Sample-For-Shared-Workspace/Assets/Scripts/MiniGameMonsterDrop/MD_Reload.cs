using UnityEngine;

using UnityEngine.SceneManagement;


namespace MiniGame_MonsterDrrop
{
    public class MD_Reload : MonoBehaviour
    {
        void Update()
        {
            if (Input.touchCount > 0)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
            }
        }
    }
}