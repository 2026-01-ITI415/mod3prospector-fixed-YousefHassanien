using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This enum defines the specific states a card can be in.
public enum eCardState {
    drawpile,
    tableau,
    target,
    discard
}

public class CardPyramid : Card {
    
    [Header("Set Dynamically: CardPyramid")]
    public eCardState state = eCardState.drawpile;
    
    // The hiddenBy list stores references to any cards that are on top of this one in the pyramid.
    public List<CardPyramid> hiddenBy = new List<CardPyramid>();
    
    public int layoutID;
    public SlotDef slotDef;

    // Intercepts the player's mouse click
    public void OnMouseUpAsButton() {
        // Talks to YOUR specific main script (Prospector)
        Prospector.S.CardClicked(this);
    }
}