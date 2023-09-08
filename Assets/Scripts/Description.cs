using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;    
using System.IO;

[XmlRoot("description")]
public class Description

{
 [XmlElement("text")]
  public string text;

    [XmlElement("node")]
    public Node[]  nodes;

     public static Description Load(TextAsset _xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Description));
        StringReader reader = new StringReader(_xml.text);
        Description dial = serializer.Deserialize(reader) as Description;
        return dial;
    }
}

[System.Serializable]
public class Node
{
    [XmlElement("infotext")]
    public string Infotext;
}

