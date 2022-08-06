using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soundManager : MonoBehaviour
{
    public static soundManager Instance;
    [SerializeField] public AudioSource chew;
    [SerializeField] public AudioSource ringCookie;
    [SerializeField] public AudioSource ringCookie2;
    [SerializeField] public AudioSource ringWrapping;
    [SerializeField] public AudioSource intractions1;    
    [SerializeField] public AudioSource intractions2;
    [SerializeField] public AudioSource intractions3;
    [SerializeField] public AudioSource intractions4;
    [SerializeField] public AudioSource intractions5;
    [SerializeField] public List <AudioSource> eggCrecking;
    [SerializeField] public AudioSource candy;
    //[SerializeField] AudioSource chew;
    //[SerializeField] AudioSource chew;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        Instance = this;

    }

    private void OnEnable()
    {
        Cursor.visible = false;
    }
    // Start is called before the first frame update
    public void PlayChew()
    {
        chew.Play();
    }
    public void playRingCookie()
    {
        ringCookie.Play();
    }

    public void playRingCookie2()
    {
        ringCookie2.Play();
    }
    public void playRingWrapping()
    {
        ringWrapping.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(1);
        }
    }
}
