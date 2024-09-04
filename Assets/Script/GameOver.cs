using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //•Ç(WallBottom)‚É‚Ô‚Â‚©‚Á‚½‚Æ‚«
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Result");
        Destroy(collision.gameObject);
    }
}
