using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using CodeMonkey.Utils;

public class HitCounterScript : MonoBehaviour
{
    [SerializeField] public PlayerAttack player;
    public TextMeshProUGUI textMeshPro;

    public int hitCount;

    public void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        hitCount = 0;


    }
    public void Update()
    {

        {
           // Debug.Log("Entered");
            hitCount++;
            SetHitCounter(player.HitCounterInt);

        }
    }
    public void SetHitCounter(int hitCount)
    {

        textMeshPro.SetText(hitCount.ToString());
    }


}