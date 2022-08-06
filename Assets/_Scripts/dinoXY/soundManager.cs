using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager Instance;
    [SerializeField] AudioSource chew;
    [SerializeField] AudioSource ringCookie;
    [SerializeField] AudioSource ringWrapping;
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
    // Start is called before the first frame update
    public void PlayChew()
    {
        chew.Play();
    }
    public void playRingCookie()
    {
        ringCookie.Play();
    }

    public void playRingWrapping()
    {
        ringWrapping.Play();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
