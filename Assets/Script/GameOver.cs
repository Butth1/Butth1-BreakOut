using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //��(WallBottom)�ɂԂ������Ƃ�
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Result");
        Destroy(collision.gameObject);
    }
}
