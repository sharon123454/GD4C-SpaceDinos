using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MayorOfFunkyTown : MonoBehaviour
{

    private void start()
    {
        Cursor.visible = true;
    }
    public void loadEgg() 
    {

        Cursor.visible = false;
        SceneManager.LoadScene(0);
    }
    public void loadLeftRight()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(2);
    }
    public void loadSharon3()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(3);
    }
    public void loadSharon4()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(4);
    }
    public void loadSharon5()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(5);
    }


}
