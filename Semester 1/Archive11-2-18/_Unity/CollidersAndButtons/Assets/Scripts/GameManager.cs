using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    //Singleton itself
    static GameManager instance;

    //Accessor for the singleton
    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }

    public Character Character
    { get; set; }

    //Because we only ever want one, we must make a private constructor, not a public constructor
    private GameManager()
    {
        //Create a new object with a script of type Updater to update the GameManager
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }

    private void Update()
    {
        //Game Logic would go here like managing time, level resets, etc.
    }

    //Internal class used to update the GameManager since GameManager doesn't inherit from MonoBehavior
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }


}
