using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ObjectSelector
{
    private static int objSelected;

    //gets and returns currently selected construct
    public static int ObjSelect
    {
        get{
            return objSelected;
        }

        set{
            objSelected = value;

        }
    }


}
