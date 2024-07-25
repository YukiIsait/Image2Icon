using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace Image2Icon.Models;

public class IconSizeModel : ObservableObject
{
    private readonly HashSet<int> sizes = new();

    public IReadOnlyCollection<int> Sizes => sizes;

    public bool Size256
    {
        get => sizes.Contains(256);
        set => SetProperty(sizes.Contains(256), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(256);
            }
            else
            {
                sizes.Remove(256);
            }
        });
    }

    public bool Size128
    {
        get => sizes.Contains(128);
        set => SetProperty(sizes.Contains(128), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(128);
            }
            else
            {
                sizes.Remove(128);
            }
        });
    }

    public bool Size96
    {
        get => sizes.Contains(96);
        set => SetProperty(sizes.Contains(96), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(96);
            }
            else
            {
                sizes.Remove(96);
            }
        });
    }

    public bool Size80
    {
        get => sizes.Contains(80);
        set => SetProperty(sizes.Contains(80), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(80);
            }
            else
            {
                sizes.Remove(80);
            }
        });
    }

    public bool Size72
    {
        get => sizes.Contains(72);
        set => SetProperty(sizes.Contains(72), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(72);
            }
            else
            {
                sizes.Remove(72);
            }
        });
    }

    public bool Size64
    {
        get => sizes.Contains(64);
        set => SetProperty(sizes.Contains(64), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(64);
            }
            else
            {
                sizes.Remove(64);
            }
        });
    }

    public bool Size60
    {
        get => sizes.Contains(60);
        set => SetProperty(sizes.Contains(60), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(60);
            }
            else
            {
                sizes.Remove(60);
            }
        });
    }

    public bool Size48
    {
        get => sizes.Contains(48);
        set => SetProperty(sizes.Contains(48), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(48);
            }
            else
            {
                sizes.Remove(48);
            }
        });
    }

    public bool Size40
    {
        get => sizes.Contains(40);
        set => SetProperty(sizes.Contains(40), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(40);
            }
            else
            {
                sizes.Remove(40);
            }
        });
    }

    public bool Size32
    {
        get => sizes.Contains(32);
        set => SetProperty(sizes.Contains(32), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(32);
            }
            else
            {
                sizes.Remove(32);
            }
        });
    }

    public bool Size24
    {
        get => sizes.Contains(24);
        set => SetProperty(sizes.Contains(24), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(24);
            }
            else
            {
                sizes.Remove(24);
            }
        });
    }

    public bool Size20
    {
        get => sizes.Contains(20);
        set => SetProperty(sizes.Contains(20), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(20);
            }
            else
            {
                sizes.Remove(20);
            }
        });
    }

    public bool Size16
    {
        get => sizes.Contains(16);
        set => SetProperty(sizes.Contains(16), value, newValue =>
        {
            if (newValue)
            {
                sizes.Add(16);
            }
            else
            {
                sizes.Remove(16);
            }
        });
    }
}
