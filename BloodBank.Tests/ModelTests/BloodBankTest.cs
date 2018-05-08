using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using BloodBank.Models;
using System;

namespace BloodBank.Tests
{
  [TestClass]
  public class BloodBankTest : IDisposable
  {
    public BloodBankTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=bloodbank_test;";
    }
  }
}
