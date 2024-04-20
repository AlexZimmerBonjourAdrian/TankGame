using Complete;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha4))
        //{
        //    LevelManager.Inst.LoadSceneAsync("PlayGround");
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha5))
        //{
        //    LevelManager.Inst.LoadSceneAsync("demo_day");
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha6))
        //{
        //    LevelManager.Inst.LoadSceneAsyncAdditive("MenuTest");
        //}
    }

    public void SwitchScene()
    {
        LevelManager.Inst.LoadSceneAsync(name);
    }

    public void SwitchSceneIndexName()
    {
        LevelManager.Inst.LoadScene(name);
    }
    public void SwitchSceneIndex(int Index)
    {
        LevelManager.Inst.LoadScene(Index);
    }


    public void Test(Vector3 vector)
    {
        Debug.Log(vector);
    }

}
