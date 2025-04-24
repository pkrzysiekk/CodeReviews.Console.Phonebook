using System.ComponentModel;

namespace PhoneBook.Models;

public enum MenuChoices
{
    [Description("Add Contact")]
    AddContact,

    [Description("View Contacts")]
    ViewContacts,

    [Description("Update Contact")]
    UpdateContact,

    [Description("Delete Contact")]
    DeleteContact,

    [Description("Exit")]
    Exit
}