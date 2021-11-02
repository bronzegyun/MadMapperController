using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class MadMapperController : MonoBehaviour
{
    [Header("OSC Settings")]
    public OSCTransmitter Transmitter;
    
    public void PlayVideo(string address)
    {
        Transmitter.Send(new OSCMessage(address));
    }
}