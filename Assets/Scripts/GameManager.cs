using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] ghosts;
    public GameObject pacman;
    public Transform pellets;

    public int score { get; private set; }
    public int lives { get; private set; }
}
