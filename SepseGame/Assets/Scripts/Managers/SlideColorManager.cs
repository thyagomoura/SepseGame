using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideColorManager : MonoBehaviour
{
    public Slider slider;
    public Image alvoCor;
    public Color corFinal;

    public float valorSlider;
    public float hueOrig, saturationOrig, brightnessOrig;
    public float hueRandom, saturationRandom, brightnessRandom;

    public Color corRandom;

    // Start is called before the first frame update
    public void Start()
    {
        alvoCor = GetComponent<Image>();
        Color.RGBToHSV(alvoCor.color, out hueOrig, out saturationOrig, out brightnessOrig);
    }

    // Update is called once per frame
    public void Update()
    {
        valorSlider = slider.value;

        alvoCor.color = Color.HSVToRGB(valorSlider, saturationOrig, brightnessOrig);

        corFinal = alvoCor.color;
    }
    public void MudarBolinha(Color corzinha)
    {
        corRandom = corzinha;

        Color.RGBToHSV(corRandom, out hueRandom, out saturationRandom, out brightnessRandom);

        alvoCor.color = corRandom;
        slider.value = hueRandom;
    }
}
