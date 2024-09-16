using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomGame : MonoBehaviour
{
    [SerializeField] ControleSom _controleSom;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] bool _somMenu, _somMusic, _somGame;
    void Start()
    {
        _controleSom = Camera.main.GetComponent<ControleSom>();
        _audioSource = GetComponent<AudioSource>();

        if (_somMenu)
        {
            _controleSom._sonsMenu.Add(_audioSource);
        }
        else if (_somMusic == true)
        {
            _controleSom._sonsMusic.Add(_audioSource);
        }
        else if (_somGame == true) 
        { 
            _controleSom._sonsGame.Add(_audioSource);
        }

    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
