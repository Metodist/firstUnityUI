using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public TextMeshProUGUI text;

    public Slider weight;
    public Slider height;

    public List<GameObject> hats = new List<GameObject>();
    
    public Renderer renderer;
    void Start()
    {
        text.text = GetComponent<Rigidbody>().mass.ToString("00");
        height.value = transform.localScale.x;
        weight.value = transform.localScale.y;

    }

    public void AddHat(int hat)
    {
        for (int i = 0; i < hats.Count; i++)
        {
            if (hat == i)
            {
                hats[i].SetActive(true);
            }
            else
            {
                hats[i].SetActive(false);
            }
        }
    }
    
    public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(0f, 1000f, 0f);
    }

    public void Mass(float mass)
    {
        float result = GetComponent<Rigidbody>().mass + mass;
        result = Mathf.Clamp(result, 1f, 50f);
        GetComponent<Rigidbody>().mass = result;
        text.text = result.ToString("00");
        
    }

    public void SetHeight(float height)
    {
        transform.localScale = new Vector3(transform.localScale.x, height, transform.localScale.z);
    }
    
    public void SetWeight(float weight)
    {
        transform.localScale = new Vector3(weight, transform.localScale.y, transform.localScale.z);
    }

    public void SetMaterial(Material material)
    {
        renderer.material = material;
    }
}
