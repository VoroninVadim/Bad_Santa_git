using UnityEngine;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections;

public class load_level : MonoBehaviour {



    public GameObject bomo;
	// Use this for initialization
	void Start () {
        LevelLoad();
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    void  LevelLoad ()
    {
       // XmlTextReader  XmlReader= new XmlTextReader(@"Assets\Scene\level\level.xml");

        try
        {

    
        XDocument lvl =  XDocument.Load(@"Assets\Scene\level\level.xml");
        foreach (XElement level_1_el in lvl.Root.Elements())
        {
            switch (level_1_el.Name.ToString())
            {
                case "boom":
                    print("boom");
                    break;
                default:
                    break;

              }
          
           }


          }
        catch (XmlException)
        {
            print("Wrong   loading level");
        }

    }
}
