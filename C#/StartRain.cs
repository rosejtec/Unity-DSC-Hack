using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRain : MonoBehaviour
{
    public ParticleSystem rain;

    public bool rainStarter = false;

    [SerializeField] private float maximumRainEmission;
    [SerializeField] private float fadeInAndOutTime;
    [SerializeField] private float delayToKill;

    private float timer;

    private AudioSource source;
    [SerializeField] float maximumVolume;

    // Start is called before the first frame update
    void Start()
    {
        rain = gameObject.GetComponent<ParticleSystem>();
        source = gameObject.GetComponent<AudioSource>();
    }

    void TurnOn()
    {
        if (timer < 0) timer = 0;
        rainStarter = true;
        source.Play();
    }

    void TurnOff()
    {
        rainStarter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rainStarter)
            {
                TurnOff();
            } 
            else
            {
                TurnOn();
            }
        }

        if (rainStarter)
        {
            if (timer <= fadeInAndOutTime)
            {
                timer += Time.deltaTime;
            }
            rain.Play();

            var emission = rain.emission;
            emission.rateOverTime = timer / fadeInAndOutTime * maximumRainEmission;

            source.volume = Mathf.Pow((timer / fadeInAndOutTime), 3f) * maximumVolume;
        }

        if (!rainStarter)
        {
            if (timer > 0.0f - delayToKill)
            {
                timer -= Time.deltaTime;
            }
            var emission = rain.emission;
            if (emission.rateOverTime.constant >= 0.3) emission.rateOverTime = timer / fadeInAndOutTime * maximumRainEmission;
            if (timer <= 0.0f - delayToKill)
            {
                rain.Stop();
            }

            if (timer >= 0f)
            {
                source.volume = Mathf.Pow((timer / fadeInAndOutTime), 2f) * maximumVolume;
            }
            else
            {
                source.volume = 0;
                source.Stop();
            }
        }
    }
}
