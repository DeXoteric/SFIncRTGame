using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMainPanels : MonoBehaviour {

    [SerializeField] RectTransform panelOnGameStart;

    private RectTransform currentActivePanel;
    private RectTransform previousActivePanel;

    private Vector2 activePanelPosition;
    private Vector2 inactivePanelPosition;

    private void Start()
    {
        activePanelPosition = new Vector2(0f, 0);
        inactivePanelPosition = new Vector2(1200f, 0);

        currentActivePanel = panelOnGameStart;


    }

    public void TogglePanels(RectTransform newCurrentActivePanel)
    {
        if (currentActivePanel != null)
        {
            previousActivePanel = currentActivePanel;
            previousActivePanel.anchoredPosition = inactivePanelPosition;
        }
        currentActivePanel = newCurrentActivePanel;
        currentActivePanel.anchoredPosition = activePanelPosition;
    }
}
