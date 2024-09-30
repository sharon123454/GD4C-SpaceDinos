using UnityEngine.SceneManagement;
using UnityEngine;

public class MayorOfFunkyTown : MonoBehaviour
{
    private void Update()
    {
        Cursor.visible = true;
    }

    public void loadEgg()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void loadLeftRight()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void loadSharon3()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }
    public void loadSharon4()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void loadSharon5()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

}
