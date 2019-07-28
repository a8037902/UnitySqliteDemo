using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field,
AllowMultiple = false)]
public class FieldAttribute : System.Attribute {

    private bool mPrimaryKey;
    private bool mAutoIncrement;
    public FieldAttribute(bool primaryKey, bool autoIncrement)
    {
        mPrimaryKey = primaryKey;
        mAutoIncrement = autoIncrement;
    }

    public bool PrimaryKey
    {
        get
        {
            return mPrimaryKey;
        }
    }

    public bool AutoIncrement
    {
        get
        {
            return mAutoIncrement;
        }
    }
}
