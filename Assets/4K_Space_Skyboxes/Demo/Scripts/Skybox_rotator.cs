using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skybox_rotator : MonoBehaviour
{
    public Text skyboxNameText;
    public List<Material> skyboxes;
    private int currentSkybox = 0;

    void Start()
    {
        SetSkybox();
    }

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // increment the skybox
            currentSkybox++;
            if (currentSkybox >= skyboxes.Count)
            {
                // loop round to the first skybox if we have reached the last skybox
                currentSkybox = 0;
            }

            SetSkybox();
        }
	}

    void SetSkybox()
    {
        // set the skybox
        RenderSettings.skybox = skyboxes[currentSkybox];
        skyboxNameText.text = skyboxes[currentSkybox].name;
    }
}
