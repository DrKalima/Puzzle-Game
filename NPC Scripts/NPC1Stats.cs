using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1Stats : MonoBehaviour
{
    private int StartingNPC1Strength = 2;
    private int StartingNPC1Dexterity = 2;
    private int StartingNPC1Accuracy = 2;
    private int StartingNPC1Defense = 2;
    private int StartingNPC1Luck = 0;
    private int StartingNPC1TurnSpeed = 2;

    public int CurrentNPC1Strength;
    public int CurrentNPC1Dexterity;
    public int CurrentNPC1Accuracy;
    public int CurrentNPC1Defense;
    public int CurrentNPC1Luck;
    public int CurrentNPC1TurnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        CurrentNPC1Strength = StartingNPC1Strength;
        CurrentNPC1Dexterity = StartingNPC1Dexterity;
        CurrentNPC1Accuracy = StartingNPC1Accuracy;
        CurrentNPC1Defense = StartingNPC1Defense;
        CurrentNPC1Luck = StartingNPC1Luck;
        CurrentNPC1TurnSpeed = StartingNPC1TurnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
