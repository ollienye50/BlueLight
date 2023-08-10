using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public int energy;
    public Text enerStat;
    public bool canStreamWork = false;
    // Start is called before the first frame update

    [SerializeField]
    AudioSource errorSFX;

    public static Energy instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    void OnEnable()
    {
        EventManagerTestLiam.instance.energyUseWork.AddListener(ActivityWork);
        EventManagerTestLiam.instance.energyUseStream.AddListener(ActivityStream);
        EventManagerTestLiam.instance.dayPassed.AddListener(DayStart);
    }

    void Ondisable()
    {
        EventManagerTestLiam.instance.energyUseWork.RemoveListener(ActivityWork);
        EventManagerTestLiam.instance.energyUseStream.RemoveListener(ActivityStream);
        EventManagerTestLiam.instance.dayPassed.RemoveListener(DayStart);
    }

    void Start()
    {
        canStreamWork = true;
        DayStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DayStart()
    {
        energy = 5;
        enerStat.text = energy.ToString();
        Debug.Log("Energy:" + energy);
        canStreamWork = true;
    }

    void ActivityWork()
    {
        if (canStreamWork==true&&energy >=2) 
        {
            energy-=2;
            enerStat.text = energy.ToString();
            EventManagerTestLiam.instance.GoToWork();
        }
        else
        {
            canStreamWork=false;
            Debug.Log("nope");
            errorSFX.Play();
        }

    }

    void ActivityStream()
    {
        if (canStreamWork == true && energy >=2)
        {
            energy-=2;
            enerStat.text = energy.ToString();
            EventManagerTestLiam.instance.GoLive();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }

    }

    public void ShopCam()
    {
        if(energy >=1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            WebcamButton.instance.WebcamBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }

    public void ShopPizza()
    {
        if (energy >= 1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            PizzaButton.instance.PizzaBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }

    public void ShopNoodles()
    {
        if (energy >= 1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            NoodlesButton.instance.NoodlesBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }

    public void ShopMic()
    {
        if (energy >= 1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            MicButton.instance.MicBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }

    public void ShopLolipop()
    {
        if (energy >= 1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            LolipopButton.instance.LolipopBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }

    public void ShopDrink()
    {
        if (energy >= 1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            DrinkButton.instance.DrinkBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }

    public void ShopPoster()
    {
        if (energy >= 1)
        {
            enerStat.text = energy.ToString();
            //do the thing
            CatButton.instance.PosterBought();
        }
        else
        {
            canStreamWork = false;
            Debug.Log("nope");
            errorSFX.Play();
        }
    }
}
