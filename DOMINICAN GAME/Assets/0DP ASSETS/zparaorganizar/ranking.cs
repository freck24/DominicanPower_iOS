using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using Firebase;

using Firebase.Database;
using Proyecto26;

public class ranking : MonoBehaviour
{
    // Start is called before the first frame update



    public float l1=100;
    public float l2=70;
    public float l3=60;
    public float l4=25;
    public float l5=22;
    public float l6=21;
    public float l7=20;
    public float l8=10;
    public Text n1;
    public Text n2;
    public Text n3;
    public Text n4;
    public Text n5;
    public Text n6;
    public Text n7;
    public Text n8;
    
    public Text ln1;
    public Text ln2;
    public Text ln3;
    public Text ln4;
    public Text ln5;
    public Text ln6;
    public Text ln7;
    public Text ln8=null;

    public int caso = 0;


    DatabaseReference reference;
    void Start()
    {

        // Set this before calling into the realtime database.
//  FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://domincanpower-70241.firebaseio.com/");
        

        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        
        Iniciar();








        /*  l1 = 70;
     l2 = 60;
     l3 = 50;
     l4 = 40;
     l5 = 30;
     l6 = 20;
     l7 = 10;
     l8 = 0;
        */

        /* l1 = PlayerPrefs.GetFloat("l1", l1);
         l2 = PlayerPrefs.GetFloat("l2", l2);
         l3 = PlayerPrefs.GetFloat("l3", l3);
         l4 = PlayerPrefs.GetFloat("l4", l4);
         l5 = PlayerPrefs.GetFloat("l5", l5);
         l6= PlayerPrefs.GetFloat("l6", l6);
         l7 = PlayerPrefs.GetFloat("l7", l7);
         l8 = PlayerPrefs.GetFloat("l8", l8);
         n1.text = PlayerPrefs.GetString("n1", n1.text);
         n2.text = PlayerPrefs.GetString("n2", n2.text);
         n3.text = PlayerPrefs.GetString("n3", n3.text);
         n4.text = PlayerPrefs.GetString("n4", n4.text);
         n5.text = PlayerPrefs.GetString("n5", n5.text);
         n6.text = PlayerPrefs.GetString("n6", n6.text);
         n7.text = PlayerPrefs.GetString("n7", n7.text);
         n8.text = PlayerPrefs.GetString("n8", n8.text);
        */








        /*   PlayerPrefs.SetFloat("l1", l1);
           PlayerPrefs.SetFloat("l2", l2);
           PlayerPrefs.SetFloat("l3", l3);
           PlayerPrefs.SetFloat("l4", l4);
           PlayerPrefs.SetFloat("l5", l5);
           PlayerPrefs.SetFloat("l6", l6);
           PlayerPrefs.SetFloat("l7", l7);
           PlayerPrefs.SetFloat("l8", l8);

           PlayerPrefs.SetString("n1", n1.text);
           PlayerPrefs.SetString("n2", n2.text);
           PlayerPrefs.SetString("n3", n3.text);
           PlayerPrefs.SetString("n4", n4.text);
           PlayerPrefs.SetString("n5", n5.text);
           PlayerPrefs.SetString("n6", n6.text);
           PlayerPrefs.SetString("n7", n7.text);
           PlayerPrefs.SetString("n8", n8.text);*/



        //revisar


        pedir();
 

}




    /*
        public void conseguir()
        {


            FirebaseDatabase.DefaultInstance
           .GetReference("Leaders").OrderByChild("score")
           .ValueChanged += HandleValueChanged;
        }
        void HandleValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (args.DatabaseError != null)
            {
                Debug.LogError(args.DatabaseError.Message);
                return;
            }
            // Do something with the data in args.Snapshot
        }

    }*/
    public GameObject CARGANDO;

    public void pedir()
    {
        recuperar();

       // organiza();
    }
    public GameObject conexion;


    public void enviardatos()
    { if (l1 != 0 && l2 != 0 && l3 != 0 && l4 != 0 && l5 != 0 && l6 != 0 && l7 != 0 && l8 != 0)
        {
            writeNewUser("01", n1.text, (int)l1);
            writeNewUser("02", n2.text, (int)l2);
            writeNewUser("03", n3.text, (int)l3);
            writeNewUser("04", n4.text, (int)l4);
            writeNewUser("05", n5.text, (int)l5);
            writeNewUser("06", n6.text, (int)l6);
            writeNewUser("07", n7.text, (int)l7);
            writeNewUser("08", n8.text, (int)l8);
            conexion.SetActive(false);
            CARGANDO.SetActive(false);
        }
        else
        {
            conexion.SetActive(true);
        }
    }




    // Update is called once per frame
    void Update()
    {
        ln1.text = l1.ToString("f0");
        ln2.text = l2.ToString("f0");
        ln3.text = l3.ToString("f0");
        ln4.text = l4.ToString("f0");
        ln5.text = l5.ToString("f0");
        ln6.text = l6.ToString("f0");
        ln7.text = l7.ToString("f0");
    }



    User user = new User();
    private void writeNewUser(string userId, string name, int email)
    {
        User user = new User(name, email);
        string json = JsonUtility.ToJson(user);

       reference.Child("users").Child(userId).SetRawJsonValueAsync(json);
    }

    void Iniciar()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                //   app = Firebase.FirebaseApp.DefaultInstance;

                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }




   

 
   public void  recuperar()
    {
        RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/01" + ".json").Then(onResolved: response =>
            {

                user = response;
                l1 = user.email;
                n1.text = user.username;

            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/02" + ".json").Then(onResolved: response =>
            {

                user = response;
                l2 = user.email;
                n2.text = user.username;
            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/03" + ".json").Then(onResolved: response =>
            {

                user = response;
                l3 = user.email;
                n3.text = user.username;
            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/04" + ".json").Then(onResolved: response =>
            {

                user = response;
                l4 = user.email;
                n4.text = user.username;
            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/05" + ".json").Then(onResolved: response =>
            {

                user = response;
                l5 = user.email;
                n5.text = user.username;
            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/06" + ".json").Then(onResolved: response =>
            {

                user = response;
                l6 = user.email;
                n6.text = user.username;

            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/07" + ".json").Then(onResolved: response =>
            {

                user = response;
                l7 = user.email;
                n7.text = user.username;
            });  RestClient.Get<User>("https://domincanpower-70241.firebaseio.com/users/08" + ".json").Then(onResolved: response =>
            {

                user = response;
                l8 = user.email;
                n8.text = user.username;
            });
       // organiza();
        StartCoroutine(ENVDAT());

        







    }

    public void organiza()
    {
        if (PlayerPrefs.GetFloat("niveld", 0) > l1)
        {
            n8.text = n7.text;
            n7.text = n6.text;
            n6.text = n5.text;
            n5.text = n4.text;
            n4.text = n3.text;
            n3.text = n2.text;
            n2.text = n1.text;

            l8 = l7;
            l7 = l6;
            l6 = l5;
            l5 = l4;
            l4 = l3;
            l3 = l2;
            l2 = l1;
            l1 = PlayerPrefs.GetFloat("niveld", 0);
            n1.text = PlayerPrefs.GetString("nombre", "null");
            caso = 1;


        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l2 && n1.text != PlayerPrefs.GetString("nombre", "null"))
        {

            l8 = l7;
            l7 = l6;
            l6 = l5;
            l5 = l4;
            l4 = l3;
            l3 = l2;
            n8.text = n7.text;
            n7.text = n6.text;
            n6.text = n5.text;
            n5.text = n4.text;
            n4.text = n3.text;
            n3.text = n2.text;
            caso = 2;
            l2 = PlayerPrefs.GetFloat("niveld", 0);
            n2.text = PlayerPrefs.GetString("nombre", "null");
        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l3 && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null"))
        {

            l8 = l7;
            l7 = l6;
            l6 = l5;
            l5 = l4;
            l4 = l3;
            n8.text = n7.text;
            n7.text = n6.text;
            n6.text = n5.text;
            n5.text = n4.text;
            n4.text = n3.text;
            caso = 3;
            l3 = PlayerPrefs.GetFloat("niveld", 0);
            n3.text = PlayerPrefs.GetString("nombre", "null");
        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l4 && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null"))
        {

            l8 = l7;
            l7 = l6;
            l6 = l5;
            l5 = l4;
            n8.text = n7.text;
            n7.text = n6.text;
            n6.text = n5.text;
            n5.text = n4.text;
            caso = 4;
            l4 = PlayerPrefs.GetFloat("niveld", 0);
            n4.text = PlayerPrefs.GetString("nombre", "null");
        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l5 && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null") && n4.text != PlayerPrefs.GetString("nombre", "null"))
        {

            l8 = l7;
            l7 = l6;
            l6 = l5;
            n8.text = n7.text;
            n7.text = n6.text;
            n6.text = n5.text;
            caso = 5;
            l5 = PlayerPrefs.GetFloat("niveld", 0);
            n5.text = PlayerPrefs.GetString("nombre", "null");
        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l6 && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null") && n4.text != PlayerPrefs.GetString("nombre", "null") && n5.text != PlayerPrefs.GetString("nombre", "null"))
        {

            l8 = l7;
            l7 = l6;
            n8.text = n7.text;
            n7.text = n6.text;
            caso = 6;
            l6 = PlayerPrefs.GetFloat("niveld", 0);
            n6.text = PlayerPrefs.GetString("nombre", "null");
        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l7 && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null") && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null") && n4.text != PlayerPrefs.GetString("nombre", "null") && n5.text != PlayerPrefs.GetString("nombre", "null") && n6.text != PlayerPrefs.GetString("nombre", "null"))
        {

            l8 = l7;
            n8.text = n7.text;
            caso = 7;
            l7 = PlayerPrefs.GetFloat("niveld", 0);
            n7.text = PlayerPrefs.GetString("nombre", "null");
        }
        else if (PlayerPrefs.GetFloat("niveld", 0) > l8 && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null") && n1.text != PlayerPrefs.GetString("nombre", "null") && n2.text != PlayerPrefs.GetString("nombre", "null") && n3.text != PlayerPrefs.GetString("nombre", "null") && n4.text != PlayerPrefs.GetString("nombre", "null") && n5.text != PlayerPrefs.GetString("nombre", "null") && n6.text != PlayerPrefs.GetString("nombre", "null"))

        {
            caso = 8;
            l8 = PlayerPrefs.GetFloat("niveld", 0);
            n8.text = PlayerPrefs.GetString("nombre", "null");
        }
        switch (caso)
        {
            case 1:
                if (PlayerPrefs.GetString("nombre", "null") == n2.text)
                {
                    n2.text = n3.text;
                    n3.text = n4.text;
                    n4.text = n5.text;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;

                    l2 = l3;
                    l3 = l4;
                    l4 = l5;
                    l5 = l6;
                    l6 = l7;
                    l7 = l8;



                }
                else if (PlayerPrefs.GetString("nombre", "null") == n3.text)
                {

                    l3 = l4;
                    l4 = l5;
                    l5 = l6;
                    l6 = l7;
                    l7 = l8;

                    n3.text = n4.text;
                    n4.text = n5.text;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else
                if (PlayerPrefs.GetString("nombre", "null") == n4.text)
                {



                    l4 = l5;
                    l5 = l6;
                    l6 = l7;
                    l7 = l8;
                    n4.text = n5.text;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n5.text)
                {



                    l5 = l6;
                    l6 = l7;
                    l7 = l8;

                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n6.text)
                {




                    l6 = l7;
                    l7 = l8;

                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n7.text)
                {




                    l7 = l8;


                    n7.text = n8.text;
                }
                break;
            case 2:
                if (PlayerPrefs.GetString("nombre", "null") == n3.text)
                {


                    l3 = l4;
                    l4 = l5;
                    l5 = l6;
                    l6 = l7;
                    l7 = l8;
                    n3.text = n4.text;
                    n4.text = n5.text;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else
                     if (PlayerPrefs.GetString("nombre", "null") == n4.text)
                {



                    l4 = l5;
                    l5 = l6;
                    l6 = l7;
                    l7 = l8;
                    n4.text = n5.text;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n5.text)
                {



                    l5 = l6;
                    l6 = l7;
                    l7 = l8;

                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n6.text)
                {





                    l6 = l7;
                    l7 = l8;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n7.text)
                {





                    l7 = l8;

                    n7.text = n8.text;
                }
                break;
            case 3:


                if (PlayerPrefs.GetString("nombre", "null") == n4.text)
                {



                    l4 = l5;
                    l5 = l6;
                    l6 = l7;
                    l7 = l8;
                    n4.text = n5.text;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n5.text)
                {




                    l5 = l6;
                    l6 = l7;
                    l7 = l8;
                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n6.text)
                {





                    l6 = l7;
                    l7 = l8;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n7.text)
                {





                    l7 = l8;

                    n7.text = n8.text;
                }

                break;
            case 4:

                if (PlayerPrefs.GetString("nombre", "null") == n5.text)
                {



                    l5 = l6;
                    l6 = l7;
                    l7 = l8;

                    n5.text = n6.text;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n6.text)
                {




                    l6 = l7;
                    l7 = l8;

                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n7.text)
                {





                    l7 = l8;

                    n7.text = n8.text;
                }

                break;
            case 5:

                if (PlayerPrefs.GetString("nombre", "null") == n6.text)
                {





                    l6 = l7;
                    l7 = l8;
                    n6.text = n7.text;
                    n7.text = n8.text;
                }
                else if (PlayerPrefs.GetString("nombre", "null") == n7.text)
                {



                    l7 = l8;


                    n7.text = n8.text;
                }

                break;
            case 6:
                if (PlayerPrefs.GetString("nombre", "null") == n7.text)
                {



                    l7 = l8;

                    n7.text = n8.text;
                }

                break;

        }



    }












    public IEnumerator ENVDAT()
    {
        yield return new WaitForSecondsRealtime(5);
        if (l1 != 0 && l2 != 0 && l3 != 0 && l4 != 0 && l5 != 0 && l6 != 0 && l7 != 0 && l8 != 0)
        { organiza(); }
        enviardatos();
    }


   public void quit()
    {
        conexion.SetActive(false);
    }


}










    




public class User
{
    public string username;
    public int email;

    public User()
    {
    }

    public User(string username, int email)
    {
        this.username = username;
        this.email = email;
    }
}


