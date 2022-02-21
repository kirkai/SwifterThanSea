using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public static bool isCutSceneOn;
    public Animator camAnim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutscene), 1.5f);
        }
    }

    void StopCutscene()
    {
        camAnim.SetBool("cutscene1", false);
    }
}
