using UnityEngine;
using UnityEngine.UI;

public class ScaleAndRotateSlider : MonoBehaviour {
    // we need two sliders
    // we need min and max values of each
    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotMinValue;
    public float rotMaxValue;

    private Slider rotateSlider;
    

    private Slider scaleSlider;


    private void Start() {
        // find the sliders by name
        //initialize the max and min value when starting
        // Add a listener to the slider when value is changed


        scaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);


        rotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);


    }

    private void ScaleSliderUpdate(float value) {
        transform.localScale = new Vector3(value, value, value);
    }

    private void RotateSliderUpdate(float value) {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}