using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConfigureInit : MonoBehaviour {
    public UnityEvent onPlay;
    void Awake() {
        onPlay.Invoke();
    }

}
