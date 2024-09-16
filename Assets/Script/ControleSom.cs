using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControleSom : MonoBehaviour
{
    [SerializeField] bool _somMenuMute, _somMenuMusic, _somGameMute;
    [SerializeField] TextMeshProUGUI _textSomMenu, _textSomMusic, _textSomGame;
    public List<AudioSource> _sonsMenu = new List<AudioSource>();
    public List<AudioSource> _sonsMusic = new List<AudioSource>();
    public List<AudioSource> _sonsGame = new List<AudioSource>();
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ListSomMenuMUTE(bool value)
    {
        
        _somMenuMute = value;
        for (int i = 0; i < _sonsMenu.Count; i++)
        {
            _sonsMenu[i].mute = value;
        }
    }
    public void SomMenuMute()
    {
        
        _somMenuMute = !_somMenuMute;
        if (_somMenuMute)
        {
            _textSomMenu.text = "Som";
        }
        else 
        {
            _textSomMenu.text = "Mute";
        }

        for (int i = 0; i < _sonsMenu.Count ; i++)
        {
            _sonsMenu[i].mute = _somMenuMute;
        }
        
    }
    public void SomMusicMute()
    {

        _somMenuMusic = !_somMenuMusic;
        if (_somMenuMusic)
        {
            _textSomMusic.text = "Som Music";
            for (int i = 0; i < _sonsMusic.Count; i++)
            {
                _sonsMusic[i].Stop();
            }
        }
        else
        {
            _textSomMusic.text = "Mute Music";
            for (int i = 0; i < _sonsMusic.Count; i++)
            {
                _sonsMusic[i].Play();
            }
        }

       

    }
    public void SomGameMusic()
    {

        _somGameMute = !_somGameMute;
        if (_somGameMute)
        {
            _textSomGame.text = "Som Game";
        }
        else
        {
            _textSomGame.text = "Mute Game";
        }
            for (int i = 0; i < _sonsGame.Count; i++)
            {
            _sonsGame[i].mute = _somGameMute;
            }



    }
}
