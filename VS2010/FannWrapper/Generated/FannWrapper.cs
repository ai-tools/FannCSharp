//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FannWrap {

public class FannWrapper {
  public static void fann_set_error_log(fann_error errdat, SWIGTYPE_p_FILE log_file) {
    FannWrapperPINVOKE.fann_set_error_log(fann_error.getCPtr(errdat), SWIGTYPE_p_FILE.getCPtr(log_file));
  }

  public static fann_errno_enum fann_get_errno(fann_error errdat) {
    fann_errno_enum ret = (fann_errno_enum)FannWrapperPINVOKE.fann_get_errno(fann_error.getCPtr(errdat));
    return ret;
  }

  public static void fann_reset_errno(fann_error errdat) {
    FannWrapperPINVOKE.fann_reset_errno(fann_error.getCPtr(errdat));
  }

  public static void fann_reset_errstr(fann_error errdat) {
    FannWrapperPINVOKE.fann_reset_errstr(fann_error.getCPtr(errdat));
  }

  public static string fann_get_errstr(fann_error errdat) {
    string ret = FannWrapperPINVOKE.fann_get_errstr(fann_error.getCPtr(errdat));
    return ret;
  }

  public static void fann_print_error(fann_error errdat) {
    FannWrapperPINVOKE.fann_print_error(fann_error.getCPtr(errdat));
  }

  public static SWIGTYPE_p_FILE fann_default_error_log {
    set {
      FannWrapperPINVOKE.fann_default_error_log_set(SWIGTYPE_p_FILE.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_default_error_log_get();
      SWIGTYPE_p_FILE ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FILE(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char FANN_TRAIN_NAMES {
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.FANN_TRAIN_NAMES_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char FANN_ACTIVATIONFUNC_NAMES {
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.FANN_ACTIVATIONFUNC_NAMES_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char FANN_ERRORFUNC_NAMES {
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.FANN_ERRORFUNC_NAMES_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char FANN_STOPFUNC_NAMES {
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.FANN_STOPFUNC_NAMES_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char FANN_NETTYPE_NAMES {
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.FANN_NETTYPE_NAMES_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_float new_float_p_array(int nelements) {
    global::System.IntPtr cPtr = FannWrapperPINVOKE.new_float_p_array(nelements);
    SWIGTYPE_p_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_float(cPtr, false);
    return ret;
  }

  public static void delete_float_p_array(SWIGTYPE_p_p_float ary) {
    FannWrapperPINVOKE.delete_float_p_array(SWIGTYPE_p_p_float.getCPtr(ary));
  }

  public static SWIGTYPE_p_float float_p_array_getitem(SWIGTYPE_p_p_float ary, int index) {
    global::System.IntPtr cPtr = FannWrapperPINVOKE.float_p_array_getitem(SWIGTYPE_p_p_float.getCPtr(ary), index);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public static void float_p_array_setitem(SWIGTYPE_p_p_float ary, int index, SWIGTYPE_p_float value) {
    FannWrapperPINVOKE.float_p_array_setitem(SWIGTYPE_p_p_float.getCPtr(ary), index, SWIGTYPE_p_float.getCPtr(value));
  }

  public static SWIGTYPE_p_float new_float_array(int nelements) {
    global::System.IntPtr cPtr = FannWrapperPINVOKE.new_float_array(nelements);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public static void delete_float_array(SWIGTYPE_p_float ary) {
    FannWrapperPINVOKE.delete_float_array(SWIGTYPE_p_float.getCPtr(ary));
  }

  public static float float_array_getitem(SWIGTYPE_p_float ary, int index) {
    float ret = FannWrapperPINVOKE.float_array_getitem(SWIGTYPE_p_float.getCPtr(ary), index);
    return ret;
  }

  public static void float_array_setitem(SWIGTYPE_p_float ary, int index, float value) {
    FannWrapperPINVOKE.float_array_setitem(SWIGTYPE_p_float.getCPtr(ary), index, value);
  }

  public static readonly int FANN_ERRSTR_MAX = FannWrapperPINVOKE.FANN_ERRSTR_MAX_get();
}

}
