using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.WebRequestMethods;

public class LinkScripts : MonoBehaviour
{
    [SerializeField] GameObject _linkText;
    
   

    public void ButonLink()
    {
        _linkText.SetActive(true);
        
    }
    public void LinkedinEmirhan()
    {
        Application.OpenURL("https://tr.linkedin.com/in/emirhan-kayap%C4%B1nar-72319420a/en?trk=people-guest_people_search-card");

    }
    public void LinkedinTurker()
    {
        Application.OpenURL("https://tr.linkedin.com/in/turker-demiroz-233798195/en?trk=people-guest_people_search-card");

    }
    public void LinkedinOzgur()
    {
        Application.OpenURL("https://tr.linkedin.com/in/ozgurbosnali");

    }
    public void LinkedinFurkan()
    {
        Application.OpenURL("https://tr.linkedin.com/in/furkan-borakazi-19bb05230/en");

    }
    public void LinkedinSadik()
    {
        Application.OpenURL("https://tr.linkedin.com/in/sad%C4%B1k-%C3%A7okol-2b800677/en");

    }

}
