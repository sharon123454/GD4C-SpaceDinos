using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MayorOfFunkyTown : MonoBehaviour
{

    private void start()
    {
        Cursor.lockState = CursorLockMode.None ;
    }
    public void loadEgg() 
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(0);
    }
    public void loadLeftRight()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(2);
    }
    public void loadSharon3()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(3);
    }
    public void loadSharon4()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(4);
    }
    public void loadSharon5()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(5);
    }


}
