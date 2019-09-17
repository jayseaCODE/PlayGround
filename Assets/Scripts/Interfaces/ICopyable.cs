using System.Collections;
using System.Collections.Generic;

public interface ICopyable {

    /// <summary>
    /// Copy the object given by its memory reference
    /// </summary>
    /// <returns></returns>
    ICopyable Copy(string name);
}
