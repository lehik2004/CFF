using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooking : MonoBehaviour
{
    [SerializeField] private Image uifill;

    public float cooked;
    public int Duration;
    private int remainingDuration;
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "stove")
        {
            Invoke("Welldone", 0);
            //Material Fryed = new Material(Shader.Find("Standard"));
            //Fryed.SetTexture("_MainTex", myTexture);
            //other.GetComponent<MeshRenderer>().material = Fryed;
        }
    }
    public Texture myTexture;
    public GameObject timer;
    void Fryed()
    {
        Material Fryyed = new Material(Shader.Find("Standard"));
        Fryyed.SetTexture("_MainTex", myTexture);
        GetComponent<MeshRenderer>().material = Fryyed;
        cooked = 1;
    }

    void Welldone()
    {   
        timer.SetActive(true);
        Being(Duration);
        StartCoroutine(zharka());
    }

    private void Being(int Second)
    {
        remainingDuration = Second;
    }

    IEnumerator zharka()
    {
        while (remainingDuration >= 0)
        {
            uifill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        Invoke("Fryed", 0);
    }
}
