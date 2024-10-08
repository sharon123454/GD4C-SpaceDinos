using UnityEngine.SceneManagement;
using UnityEngine;

public class EggGameManager : MonoBehaviour
{
    [SerializeField] SpriteRenderer BGImage;
    [SerializeField] Sprite[] spriteArr;
    int counter = 0;

    [SerializeField] float passValue;
    //TB = TimeBetween
    float TB2ndto1st = 0, TB3rdto2nd = 0, timer = 0;
    int _clickNum = 0;
    bool runTime = false;

    private void Start()
    {
        soundManager.Instance.intractions1.Play();
    }
    private void Update()
    {
        if (counter == 15)
        {
            Invoke("LoadNextScene", 3);
        }
        if (runTime)
            timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            ScreenClicked();

            switch (_clickNum)
            {
                case 0:
                    FirstClick();
                    return;
                case 1:
                    SecondClick();
                    return;
                case 2:
                    ThirdClick();
                    return;
            }
        }

    }

    public void ScreenClicked()
    {
        if (counter < spriteArr.Length)
        {
            BGImage.sprite = spriteArr[counter];
            counter++;
            int x = Random.Range(0, soundManager.Instance.eggCrecking.Count);
            soundManager.Instance.eggCrecking[x].Play();
        }
    }

    void FirstClick()
    {
        _clickNum++;
        runTime = true;
    }

    void SecondClick()
    {
        _clickNum++;
        runTime = false;
        TB2ndto1st = timer;
        timer = 0;
        runTime = true;
    }

    void ThirdClick()
    {
        runTime = false;
        TB3rdto2nd = timer;
        timer = 0;
        Calculation();
        _clickNum = 0;
    }

    void Calculation()
    {
        float testedValue = TB2ndto1st + TB3rdto2nd;

        if (testedValue < passValue)
            print("Sonic?");

        TB2ndto1st = 0;
        TB3rdto2nd = 0;
    }

    private void LoadNextScene() { SceneManager.LoadScene(1); }

}