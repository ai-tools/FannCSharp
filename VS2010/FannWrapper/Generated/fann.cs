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

public class fann : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal fann(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(fann obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~fann() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FannWrapperPINVOKE.delete_fann(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public fann_errno_enum errno_f {
    set {
      FannWrapperPINVOKE.fann_errno_f_set(swigCPtr, (int)value);
    } 
    get {
      fann_errno_enum ret = (fann_errno_enum)FannWrapperPINVOKE.fann_errno_f_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_FILE error_log {
    set {
      FannWrapperPINVOKE.fann_error_log_set(swigCPtr, SWIGTYPE_p_FILE.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_error_log_get(swigCPtr);
      SWIGTYPE_p_FILE ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FILE(cPtr, false);
      return ret;
    } 
  }

  public string errstr {
    set {
      FannWrapperPINVOKE.fann_errstr_set(swigCPtr, value);
    } 
    get {
      string ret = FannWrapperPINVOKE.fann_errstr_get(swigCPtr);
      return ret;
    } 
  }

  public float learning_rate {
    set {
      FannWrapperPINVOKE.fann_learning_rate_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_learning_rate_get(swigCPtr);
      return ret;
    } 
  }

  public float learning_momentum {
    set {
      FannWrapperPINVOKE.fann_learning_momentum_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_learning_momentum_get(swigCPtr);
      return ret;
    } 
  }

  public float connection_rate {
    set {
      FannWrapperPINVOKE.fann_connection_rate_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_connection_rate_get(swigCPtr);
      return ret;
    } 
  }

  public fann_nettype_enum network_type {
    set {
      FannWrapperPINVOKE.fann_network_type_set(swigCPtr, (int)value);
    } 
    get {
      fann_nettype_enum ret = (fann_nettype_enum)FannWrapperPINVOKE.fann_network_type_get(swigCPtr);
      return ret;
    } 
  }

  public fann_layer first_layer {
    set {
      FannWrapperPINVOKE.fann_first_layer_set(swigCPtr, fann_layer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_first_layer_get(swigCPtr);
      fann_layer ret = (cPtr == global::System.IntPtr.Zero) ? null : new fann_layer(cPtr, false);
      return ret;
    } 
  }

  public fann_layer last_layer {
    set {
      FannWrapperPINVOKE.fann_last_layer_set(swigCPtr, fann_layer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_last_layer_get(swigCPtr);
      fann_layer ret = (cPtr == global::System.IntPtr.Zero) ? null : new fann_layer(cPtr, false);
      return ret;
    } 
  }

  public uint total_neurons {
    set {
      FannWrapperPINVOKE.fann_total_neurons_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_total_neurons_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_input {
    set {
      FannWrapperPINVOKE.fann_num_input_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_num_input_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_output {
    set {
      FannWrapperPINVOKE.fann_num_output_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_num_output_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float weights {
    set {
      FannWrapperPINVOKE.fann_weights_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_weights_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_fann_neuron connections {
    set {
      FannWrapperPINVOKE.fann_connections_set(swigCPtr, SWIGTYPE_p_p_fann_neuron.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_connections_get(swigCPtr);
      SWIGTYPE_p_p_fann_neuron ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_fann_neuron(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float train_errors {
    set {
      FannWrapperPINVOKE.fann_train_errors_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_train_errors_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public fann_train_enum training_algorithm {
    set {
      FannWrapperPINVOKE.fann_training_algorithm_set(swigCPtr, (int)value);
    } 
    get {
      fann_train_enum ret = (fann_train_enum)FannWrapperPINVOKE.fann_training_algorithm_get(swigCPtr);
      return ret;
    } 
  }

  public uint total_connections {
    set {
      FannWrapperPINVOKE.fann_total_connections_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_total_connections_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float output {
    set {
      FannWrapperPINVOKE.fann_output_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_output_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public uint num_MSE {
    set {
      FannWrapperPINVOKE.fann_num_MSE_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_num_MSE_get(swigCPtr);
      return ret;
    } 
  }

  public float MSE_value {
    set {
      FannWrapperPINVOKE.fann_MSE_value_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_MSE_value_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_bit_fail {
    set {
      FannWrapperPINVOKE.fann_num_bit_fail_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_num_bit_fail_get(swigCPtr);
      return ret;
    } 
  }

  public float bit_fail_limit {
    set {
      FannWrapperPINVOKE.fann_bit_fail_limit_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_bit_fail_limit_get(swigCPtr);
      return ret;
    } 
  }

  public fann_errorfunc_enum train_error_function {
    set {
      FannWrapperPINVOKE.fann_train_error_function_set(swigCPtr, (int)value);
    } 
    get {
      fann_errorfunc_enum ret = (fann_errorfunc_enum)FannWrapperPINVOKE.fann_train_error_function_get(swigCPtr);
      return ret;
    } 
  }

  public fann_stopfunc_enum train_stop_function {
    set {
      FannWrapperPINVOKE.fann_train_stop_function_set(swigCPtr, (int)value);
    } 
    get {
      fann_stopfunc_enum ret = (fann_stopfunc_enum)FannWrapperPINVOKE.fann_train_stop_function_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int callback {
    set {
      FannWrapperPINVOKE.fann_callback_set(swigCPtr, SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_callback_get(swigCPtr);
      SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void user_data {
    set {
      FannWrapperPINVOKE.fann_user_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_user_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public float cascade_output_change_fraction {
    set {
      FannWrapperPINVOKE.fann_cascade_output_change_fraction_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_cascade_output_change_fraction_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_output_stagnation_epochs {
    set {
      FannWrapperPINVOKE.fann_cascade_output_stagnation_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_output_stagnation_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public float cascade_candidate_change_fraction {
    set {
      FannWrapperPINVOKE.fann_cascade_candidate_change_fraction_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_cascade_candidate_change_fraction_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_candidate_stagnation_epochs {
    set {
      FannWrapperPINVOKE.fann_cascade_candidate_stagnation_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_candidate_stagnation_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_best_candidate {
    set {
      FannWrapperPINVOKE.fann_cascade_best_candidate_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_best_candidate_get(swigCPtr);
      return ret;
    } 
  }

  public float cascade_candidate_limit {
    set {
      FannWrapperPINVOKE.fann_cascade_candidate_limit_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_cascade_candidate_limit_get(swigCPtr);
      return ret;
    } 
  }

  public float cascade_weight_multiplier {
    set {
      FannWrapperPINVOKE.fann_cascade_weight_multiplier_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_cascade_weight_multiplier_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_max_out_epochs {
    set {
      FannWrapperPINVOKE.fann_cascade_max_out_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_max_out_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_max_cand_epochs {
    set {
      FannWrapperPINVOKE.fann_cascade_max_cand_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_max_cand_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_min_out_epochs {
    set {
      FannWrapperPINVOKE.fann_cascade_min_out_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_min_out_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_min_cand_epochs {
    set {
      FannWrapperPINVOKE.fann_cascade_min_cand_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_min_cand_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_fann_activationfunc_enum cascade_activation_functions {
    set {
      FannWrapperPINVOKE.fann_cascade_activation_functions_set(swigCPtr, SWIGTYPE_p_fann_activationfunc_enum.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_cascade_activation_functions_get(swigCPtr);
      SWIGTYPE_p_fann_activationfunc_enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_fann_activationfunc_enum(cPtr, false);
      return ret;
    } 
  }

  public uint cascade_activation_functions_count {
    set {
      FannWrapperPINVOKE.fann_cascade_activation_functions_count_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_activation_functions_count_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float cascade_activation_steepnesses {
    set {
      FannWrapperPINVOKE.fann_cascade_activation_steepnesses_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_cascade_activation_steepnesses_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public uint cascade_activation_steepnesses_count {
    set {
      FannWrapperPINVOKE.fann_cascade_activation_steepnesses_count_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_activation_steepnesses_count_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_num_candidate_groups {
    set {
      FannWrapperPINVOKE.fann_cascade_num_candidate_groups_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_cascade_num_candidate_groups_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float cascade_candidate_scores {
    set {
      FannWrapperPINVOKE.fann_cascade_candidate_scores_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_cascade_candidate_scores_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public uint total_neurons_allocated {
    set {
      FannWrapperPINVOKE.fann_total_neurons_allocated_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_total_neurons_allocated_get(swigCPtr);
      return ret;
    } 
  }

  public uint total_connections_allocated {
    set {
      FannWrapperPINVOKE.fann_total_connections_allocated_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_total_connections_allocated_get(swigCPtr);
      return ret;
    } 
  }

  public float quickprop_decay {
    set {
      FannWrapperPINVOKE.fann_quickprop_decay_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_quickprop_decay_get(swigCPtr);
      return ret;
    } 
  }

  public float quickprop_mu {
    set {
      FannWrapperPINVOKE.fann_quickprop_mu_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_quickprop_mu_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_increase_factor {
    set {
      FannWrapperPINVOKE.fann_rprop_increase_factor_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_rprop_increase_factor_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_decrease_factor {
    set {
      FannWrapperPINVOKE.fann_rprop_decrease_factor_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_rprop_decrease_factor_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_delta_min {
    set {
      FannWrapperPINVOKE.fann_rprop_delta_min_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_rprop_delta_min_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_delta_max {
    set {
      FannWrapperPINVOKE.fann_rprop_delta_max_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_rprop_delta_max_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_delta_zero {
    set {
      FannWrapperPINVOKE.fann_rprop_delta_zero_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_rprop_delta_zero_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_weight_decay_shift {
    set {
      FannWrapperPINVOKE.fann_sarprop_weight_decay_shift_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_sarprop_weight_decay_shift_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_step_error_threshold_factor {
    set {
      FannWrapperPINVOKE.fann_sarprop_step_error_threshold_factor_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_sarprop_step_error_threshold_factor_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_step_error_shift {
    set {
      FannWrapperPINVOKE.fann_sarprop_step_error_shift_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_sarprop_step_error_shift_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_temperature {
    set {
      FannWrapperPINVOKE.fann_sarprop_temperature_set(swigCPtr, value);
    } 
    get {
      float ret = FannWrapperPINVOKE.fann_sarprop_temperature_get(swigCPtr);
      return ret;
    } 
  }

  public uint sarprop_epoch {
    set {
      FannWrapperPINVOKE.fann_sarprop_epoch_set(swigCPtr, value);
    } 
    get {
      uint ret = FannWrapperPINVOKE.fann_sarprop_epoch_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float train_slopes {
    set {
      FannWrapperPINVOKE.fann_train_slopes_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_train_slopes_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float prev_steps {
    set {
      FannWrapperPINVOKE.fann_prev_steps_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_prev_steps_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float prev_train_slopes {
    set {
      FannWrapperPINVOKE.fann_prev_train_slopes_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_prev_train_slopes_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float prev_weights_deltas {
    set {
      FannWrapperPINVOKE.fann_prev_weights_deltas_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_prev_weights_deltas_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_mean_in {
    set {
      FannWrapperPINVOKE.fann_scale_mean_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_mean_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_deviation_in {
    set {
      FannWrapperPINVOKE.fann_scale_deviation_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_deviation_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_new_min_in {
    set {
      FannWrapperPINVOKE.fann_scale_new_min_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_new_min_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_factor_in {
    set {
      FannWrapperPINVOKE.fann_scale_factor_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_factor_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_mean_out {
    set {
      FannWrapperPINVOKE.fann_scale_mean_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_mean_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_deviation_out {
    set {
      FannWrapperPINVOKE.fann_scale_deviation_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_deviation_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_new_min_out {
    set {
      FannWrapperPINVOKE.fann_scale_new_min_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_new_min_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_factor_out {
    set {
      FannWrapperPINVOKE.fann_scale_factor_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FannWrapperPINVOKE.fann_scale_factor_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public fann() : this(FannWrapperPINVOKE.new_fann(), true) {
  }

}

}
