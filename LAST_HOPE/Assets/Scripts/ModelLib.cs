using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelLib : MonoBehaviour
{
  
    #region Singleton
    /// <summary>
    /// Singleton instance
    /// </summary>
    public static ModelLib Instance { get; private set; }
    #endregion

    /*
     * Editor Exposed Variables
     */
    [Header("Configuration")]
    [Tooltip("The reference to the HoloLens Game Object")]
    [SerializeField]
    private GameObject H2OModel;
    [Header("Configuration")]
    [Tooltip("The reference to the HoloLens Game Object")]
    [SerializeField]
    private GameObject CO2Model;
    [Header("Configuration")]
    [Tooltip("The reference to the HoloLens Game Object")]
    [SerializeField]
    private GameObject COModel;

    /*
     * Member Variables
     */
    // Original Values
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Vector3 originalScale;
    // Introduction to Networked Experiences: Exercise 14.7
    //
    // Add a variable to store a reference to the Photon View component
    

    /// <summary>
    /// Resource Initialization
    /// </summary>
    private void Awake()
    {
        #region Singleton Initialization
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("More than 1 Model Library instance detected! Deleting this new one.");
            Destroy(this);
            return;
        }
        #endregion

        // Error Checks
        if (H2OModel == null)
        {
            Debug.LogError("ModelLibrary: H2O model not set.");
        }
        if (CO2Model == null)
        {
            Debug.LogError("ModelLibrary: CO2 model not set.");
        }
        if (COModel == null)
        {
            Debug.LogError("ModelLibrary: CO model not set.");
        }

        // Introduction to Networked Experiences: Exercise 14.8
        //
        // Get a reference to the Photon View component
        

        // Show the hololens at the start
        ShowModel(true, false, false);

        // Save original transforms
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalScale = transform.localScale;
    }

    /// <summary>
    /// Deinitialization
    /// </summary>
    private void OnDestroy()
    {
        #region Singleton Deinitialization
        if (Instance == this)
        {
            Instance = null;
        }
        #endregion
    }

    /// <summary>
    /// Function to hide all models
    /// </summary>
    public void HideAllModels()
    {
        // Introduction to Networked Experiences: Exercise 14.11
        //
        // Take ownership of this GameObject across the network
        
 

        // Hide all models
        H2OModel.SetActive(false);
        CO2Model.SetActive(false);
        COModel.SetActive(false);
    }

    /// <summary>
    /// Function to show the model based on the parameters provided 
    /// </summary>
    /// <param name="H20">Whether to show the H20 model</param>
    /// <param name="CO2">Whether to show the CO2 model</param>
    /// <param name="CO">Whether to show the CO model</param>
    public void ShowModel(bool H20, bool CO2, bool CO)
    {
        HideAllModels();

        if (H20)
        {
            H2OModel.SetActive(true);
        }
        else if (CO2)
        {
            CO2Model.SetActive(true);
        }
        else if (CO)
        {
            COModel.SetActive(true);
        }
    }
 
    /// Function to reset the transforms of this object
    /// </summary>
    public void ResetTransforms()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        transform.localScale = originalScale;
    }

    // Introduction to Networked Experiences: Exercise 14.10
    //
    // Implement IPunObservable to synchronize showing the correct model
    

        // Introduction to Networked Experiences: Exercise 14.10.a
        //
        // OnPhotonSerializeView():
        // Check if the stream is writing
        

            // Introduction to Networked Experiences: Exercise 14.10.a
            //
            // OnPhotonSerializeView():
            // If it is, send the active states of each model in order
            


        
        // Introduction to Networked Experiences: Exercise 14.10.b
        //
        // OnPhotonSerializeView():
        // Otherwise, check if the stream is reading
        
        
            // Introduction to Networked Experiences: Exercise 14.10.b
            //
            // OnPhotonSerializeView():
            // If it is, receive the active states of each model in order 
            // and use it to update the state of the model
            
            
            
        
    
}
