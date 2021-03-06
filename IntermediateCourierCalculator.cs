﻿using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

public class IntermediateCourierCalculator
{
    private String thePath;
    private String currencyPath;
    private ArrayList entries;
    private CurrencyConverter cc;
    private IntermediateCourierCalcResult result;
    private PostageChargeCalculator pcc; 

    public IntermediateCourierCalcResult Result
    {
        get
        {
            return this.result;
        }
    }

    public IntermediateCourierCalculator(String thePath, String currencyPath)
    {
        this.thePath = thePath;
        this.currencyPath = currencyPath;
        this.cc = new CurrencyConverter(this.currencyPath);
        ReadEntries();
    }

    public double CalculateCharge(String courierName, String toLocation, double mass, String convertToCurrencyType)
    {
        ReadEntries();

        IntermediateCourier theIc = null;
        foreach (IntermediateCourier ic in this.entries)
        {
            if (ic.CompanyName.Equals(courierName, StringComparison.OrdinalIgnoreCase)
                && ic.ToLocation.Equals(toLocation, StringComparison.OrdinalIgnoreCase))
            {
                theIc = ic;
                break;
            }
        }

        if (theIc != null)
        {
            double total = theIc.CostPer100g * (mass / 100);
            if (convertToCurrencyType != null)
            {
                total = cc.Convert(theIc.CurrencyType, total, convertToCurrencyType);
            }

            // Set up an IntermediateCourierCalcResult result object.
            
            this.result = new IntermediateCourierCalcResult();
            this.result.courier = theIc;
            //*******************************Modified/Addin by Ezra************************************
            pcc = new PostageChargeCalculator();
            this.result.totalCost = new Currency(convertToCurrencyType, total);
            this.result.totalMass = mass;
            pcc.writeToCourierText(this.result.courier, this.result.totalCost, this.result.totalMass);
            //******************************************************************************************

            return total;
        }
        
        this.result = null;
        return -1;
    }

    private void ReadEntries()
    {
        this.entries = new ArrayList();
        DatabaseManager dm = new DatabaseManager(this.thePath);
        for (int i = 0; i < dm.Count; ++i)
        {
            String[] s = ((String)dm.GetObject(i)).Split('\t');
            this.entries.Add(new IntermediateCourier(s[0], s[1], s[2], Double.Parse(s[3]),
                Int32.Parse(s[4]), s[5]));
        }
    }

    public void InitCouriersComboBox(ComboBox cb)
    {
        cb.Items.Clear();
        cb.DropDownStyle = ComboBoxStyle.DropDownList;

        // Get unique entries for the couriers.
        ArrayList unique = new ArrayList();
        bool exists = false;
        foreach (IntermediateCourier ic in this.entries)
        {
            foreach (String s in unique)
            {
                if (s.Equals(ic.CompanyName, StringComparison.OrdinalIgnoreCase))
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                unique.Add(ic.CompanyName);
            }
            exists = false;
        }

        foreach (String s in unique)
        {
            cb.Items.Add(s);
        }

        cb.SelectedIndex = 0;
    }

    public void InitLocationComboBox(String companyName, ComboBox cb)
    {
        cb.Items.Clear();
        cb.DropDownStyle = ComboBoxStyle.DropDownList;

        foreach (IntermediateCourier ic in this.entries)
        {
            if (ic.CompanyName.Equals(companyName, StringComparison.OrdinalIgnoreCase))
            {
                cb.Items.Add(ic.ToLocation);
            }
        }

        cb.SelectedIndex = 0;
    }

    public void InitCurrencyComboBox(ComboBox cb)
    {
        cb.Items.Clear();
        cb.DropDownStyle = ComboBoxStyle.DropDownList;

        this.cc.InitComboBoxes(new ComboBox[] { cb });
    }

    public IntermediateCourier GetIntermediateCourier(String companyName,
        String toLocation)
    {
        foreach (IntermediateCourier ic in this.entries)
        {
            if (companyName.Equals(ic.CompanyName, StringComparison.OrdinalIgnoreCase)
                && toLocation.Equals(ic.ToLocation, StringComparison.OrdinalIgnoreCase))
            {
                return ic;
            }
        }

        return null;
    }
}