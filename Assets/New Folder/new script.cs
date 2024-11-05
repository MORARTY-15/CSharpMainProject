using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int timeHour = 18;
        bool IsWeekend = true;
        bool isEvening = (timeHour >= 18);
        bool Haveticket = false;

        bool  goToCinema = (IsWeekend || isEvening) && Haveticket;
        Debug.Log(goToCinema); 





    }
}
