using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnlockButton : MonoBehaviour
{
    public int m_ClickCount;
    public TextMeshProUGUI m_CountText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCount () 
    {
        m_ClickCount++;
        m_CountText.text = m_ClickCount.ToString();
    }
    public void BuyFeature()
    {

    }
}
