using System.ComponentModel;
using System.Windows.Input;

namespace MauiPasswordBindingWindows;

internal class MainPageViewModel : INotifyPropertyChanged
{
    public MainPageViewModel()
    {
        // Entry with IsPassword=true won't get the default value while Android does
        // Maybe because on WPF/UWP you have to use a method to set the password because the control has
        // some encryption to protect any external program to access it?
        _password1 = "password_1_ctor";
        _isPassword1 = true;

        _password2 = "password_2_ctor";
        _isPassword2 = false;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    #region Password 1

    private string _password1;
    public string Password1
    {
        get => _password1;
        set
        {
            _password1 = value;
            PropertyChanged?.Invoke(this, new(nameof(Password1)));
        }
    }

    private bool _isPassword1;
    public bool IsPassword1
    {
        get => _isPassword1;
        set
        {
            _isPassword1 = value;
            PropertyChanged?.Invoke(this, new(nameof(IsPassword1)));
        }
    }

    private ICommand _displayPasswordValueCommand1;
    public ICommand DisplayPasswordValueCommand1 => (_displayPasswordValueCommand1 ??= new Command(() => IsPassword1 = !IsPassword1));

    #endregion

    #region Password 2

    private string _password2;
    public string Password2
    {
        get => _password2;
        set
        {
            _password2 = value;
            PropertyChanged?.Invoke(this, new(nameof(Password2)));
        }
    }

    private bool _isPassword2;
    public bool IsPassword2
    {
        get => _isPassword2;
        set
        {
            _isPassword2 = value;
            PropertyChanged?.Invoke(this, new(nameof(IsPassword2)));
        }
    }

    private ICommand _displayPasswordValueCommand2;
    public ICommand DisplayPasswordValueCommand2 => (_displayPasswordValueCommand2 ??= new Command(() => IsPassword2 = !IsPassword2));

    #endregion
}
