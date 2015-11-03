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

public class neural_net : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal neural_net(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(neural_net obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~neural_net() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SwigFannPINVOKE.delete_neural_net(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public neural_net() : this(SwigFannPINVOKE.new_neural_net__SWIG_0(), true) {
  }

  public neural_net(neural_net other) : this(SwigFannPINVOKE.new_neural_net__SWIG_1(neural_net.getCPtr(other)), true) {
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public neural_net(fann other) : this(SwigFannPINVOKE.new_neural_net__SWIG_2(fann.getCPtr(other)), true) {
  }

  public void copy_from_struct_fann(fann other) {
    SwigFannPINVOKE.neural_net_copy_from_struct_fann(swigCPtr, fann.getCPtr(other));
  }

  public void destroy() {
    SwigFannPINVOKE.neural_net_destroy(swigCPtr);
  }

  public bool create_standard(uint num_layers) {
    bool ret = SwigFannPINVOKE.neural_net_create_standard(swigCPtr, num_layers);
    return ret;
  }

  public bool create_standard_array(uint num_layers, SWIGTYPE_p_unsigned_int layers) {
    bool ret = SwigFannPINVOKE.neural_net_create_standard_array(swigCPtr, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers));
    return ret;
  }

  public bool create_sparse(float connection_rate, uint num_layers) {
    bool ret = SwigFannPINVOKE.neural_net_create_sparse(swigCPtr, connection_rate, num_layers);
    return ret;
  }

  public bool create_sparse_array(float connection_rate, uint num_layers, SWIGTYPE_p_unsigned_int layers) {
    bool ret = SwigFannPINVOKE.neural_net_create_sparse_array(swigCPtr, connection_rate, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers));
    return ret;
  }

  public bool create_shortcut(uint num_layers) {
    bool ret = SwigFannPINVOKE.neural_net_create_shortcut(swigCPtr, num_layers);
    return ret;
  }

  public bool create_shortcut_array(uint num_layers, SWIGTYPE_p_unsigned_int layers) {
    bool ret = SwigFannPINVOKE.neural_net_create_shortcut_array(swigCPtr, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers));
    return ret;
  }

  public SWIGTYPE_p_float run(SWIGTYPE_p_float input) {
    global::System.IntPtr cPtr = SwigFannPINVOKE.neural_net_run(swigCPtr, SWIGTYPE_p_float.getCPtr(input));
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public void randomize_weights(float min_weight, float max_weight) {
    SwigFannPINVOKE.neural_net_randomize_weights(swigCPtr, min_weight, max_weight);
  }

  public void init_weights(training_data data) {
    SwigFannPINVOKE.neural_net_init_weights(swigCPtr, training_data.getCPtr(data));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public void print_connections() {
    SwigFannPINVOKE.neural_net_print_connections(swigCPtr);
  }

  public bool create_from_file(string configuration_file) {
    bool ret = SwigFannPINVOKE.neural_net_create_from_file(swigCPtr, configuration_file);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save(string configuration_file) {
    bool ret = SwigFannPINVOKE.neural_net_save(swigCPtr, configuration_file);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int save_to_fixed(string configuration_file) {
    int ret = SwigFannPINVOKE.neural_net_save_to_fixed(swigCPtr, configuration_file);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void train(SWIGTYPE_p_float input, SWIGTYPE_p_float desired_output) {
    SwigFannPINVOKE.neural_net_train(swigCPtr, SWIGTYPE_p_float.getCPtr(input), SWIGTYPE_p_float.getCPtr(desired_output));
  }

  public float train_epoch(training_data data) {
    float ret = SwigFannPINVOKE.neural_net_train_epoch(swigCPtr, training_data.getCPtr(data));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void train_on_data(training_data data, uint max_epochs, uint epochs_between_reports, float desired_error) {
    SwigFannPINVOKE.neural_net_train_on_data(swigCPtr, training_data.getCPtr(data), max_epochs, epochs_between_reports, desired_error);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public void train_on_file(string filename, uint max_epochs, uint epochs_between_reports, float desired_error) {
    SwigFannPINVOKE.neural_net_train_on_file(swigCPtr, filename, max_epochs, epochs_between_reports, desired_error);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_float test(SWIGTYPE_p_float input, SWIGTYPE_p_float desired_output) {
    global::System.IntPtr cPtr = SwigFannPINVOKE.neural_net_test(swigCPtr, SWIGTYPE_p_float.getCPtr(input), SWIGTYPE_p_float.getCPtr(desired_output));
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public float test_data(training_data data) {
    float ret = SwigFannPINVOKE.neural_net_test_data(swigCPtr, training_data.getCPtr(data));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float get_MSE() {
    float ret = SwigFannPINVOKE.neural_net_get_MSE(swigCPtr);
    return ret;
  }

  public void reset_MSE() {
    SwigFannPINVOKE.neural_net_reset_MSE(swigCPtr);
  }

  public void set_callback(SWIGTYPE_p_callback_type callback, SWIGTYPE_p_void user_data) {
    SwigFannPINVOKE.neural_net_set_callback(swigCPtr, SWIGTYPE_p_callback_type.getCPtr(callback), SWIGTYPE_p_void.getCPtr(user_data));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public void print_parameters() {
    SwigFannPINVOKE.neural_net_print_parameters(swigCPtr);
  }

  public training_algorithm_enum get_training_algorithm() {
    training_algorithm_enum ret = (training_algorithm_enum)SwigFannPINVOKE.neural_net_get_training_algorithm(swigCPtr);
    return ret;
  }

  public void set_training_algorithm(training_algorithm_enum training_algorithm) {
    SwigFannPINVOKE.neural_net_set_training_algorithm(swigCPtr, (int)training_algorithm);
  }

  public float get_learning_rate() {
    float ret = SwigFannPINVOKE.neural_net_get_learning_rate(swigCPtr);
    return ret;
  }

  public void set_learning_rate(float learning_rate) {
    SwigFannPINVOKE.neural_net_set_learning_rate(swigCPtr, learning_rate);
  }

  public activation_function_enum get_activation_function(int layer, int neuron) {
    activation_function_enum ret = (activation_function_enum)SwigFannPINVOKE.neural_net_get_activation_function(swigCPtr, layer, neuron);
    return ret;
  }

  public void set_activation_function(activation_function_enum activation_function, int layer, int neuron) {
    SwigFannPINVOKE.neural_net_set_activation_function(swigCPtr, (int)activation_function, layer, neuron);
  }

  public void set_activation_function_layer(activation_function_enum activation_function, int layer) {
    SwigFannPINVOKE.neural_net_set_activation_function_layer(swigCPtr, (int)activation_function, layer);
  }

  public void set_activation_function_hidden(activation_function_enum activation_function) {
    SwigFannPINVOKE.neural_net_set_activation_function_hidden(swigCPtr, (int)activation_function);
  }

  public void set_activation_function_output(activation_function_enum activation_function) {
    SwigFannPINVOKE.neural_net_set_activation_function_output(swigCPtr, (int)activation_function);
  }

  public float get_activation_steepness(int layer, int neuron) {
    float ret = SwigFannPINVOKE.neural_net_get_activation_steepness(swigCPtr, layer, neuron);
    return ret;
  }

  public void set_activation_steepness(float steepness, int layer, int neuron) {
    SwigFannPINVOKE.neural_net_set_activation_steepness(swigCPtr, steepness, layer, neuron);
  }

  public void set_activation_steepness_layer(float steepness, int layer) {
    SwigFannPINVOKE.neural_net_set_activation_steepness_layer(swigCPtr, steepness, layer);
  }

  public void set_activation_steepness_hidden(float steepness) {
    SwigFannPINVOKE.neural_net_set_activation_steepness_hidden(swigCPtr, steepness);
  }

  public void set_activation_steepness_output(float steepness) {
    SwigFannPINVOKE.neural_net_set_activation_steepness_output(swigCPtr, steepness);
  }

  public error_function_enum get_train_error_function() {
    error_function_enum ret = (error_function_enum)SwigFannPINVOKE.neural_net_get_train_error_function(swigCPtr);
    return ret;
  }

  public void set_train_error_function(error_function_enum train_error_function) {
    SwigFannPINVOKE.neural_net_set_train_error_function(swigCPtr, (int)train_error_function);
  }

  public float get_quickprop_decay() {
    float ret = SwigFannPINVOKE.neural_net_get_quickprop_decay(swigCPtr);
    return ret;
  }

  public void set_quickprop_decay(float quickprop_decay) {
    SwigFannPINVOKE.neural_net_set_quickprop_decay(swigCPtr, quickprop_decay);
  }

  public float get_quickprop_mu() {
    float ret = SwigFannPINVOKE.neural_net_get_quickprop_mu(swigCPtr);
    return ret;
  }

  public void set_quickprop_mu(float quickprop_mu) {
    SwigFannPINVOKE.neural_net_set_quickprop_mu(swigCPtr, quickprop_mu);
  }

  public float get_rprop_increase_factor() {
    float ret = SwigFannPINVOKE.neural_net_get_rprop_increase_factor(swigCPtr);
    return ret;
  }

  public void set_rprop_increase_factor(float rprop_increase_factor) {
    SwigFannPINVOKE.neural_net_set_rprop_increase_factor(swigCPtr, rprop_increase_factor);
  }

  public float get_rprop_decrease_factor() {
    float ret = SwigFannPINVOKE.neural_net_get_rprop_decrease_factor(swigCPtr);
    return ret;
  }

  public void set_rprop_decrease_factor(float rprop_decrease_factor) {
    SwigFannPINVOKE.neural_net_set_rprop_decrease_factor(swigCPtr, rprop_decrease_factor);
  }

  public float get_rprop_delta_zero() {
    float ret = SwigFannPINVOKE.neural_net_get_rprop_delta_zero(swigCPtr);
    return ret;
  }

  public void set_rprop_delta_zero(float rprop_delta_zero) {
    SwigFannPINVOKE.neural_net_set_rprop_delta_zero(swigCPtr, rprop_delta_zero);
  }

  public float get_rprop_delta_min() {
    float ret = SwigFannPINVOKE.neural_net_get_rprop_delta_min(swigCPtr);
    return ret;
  }

  public void set_rprop_delta_min(float rprop_delta_min) {
    SwigFannPINVOKE.neural_net_set_rprop_delta_min(swigCPtr, rprop_delta_min);
  }

  public float get_rprop_delta_max() {
    float ret = SwigFannPINVOKE.neural_net_get_rprop_delta_max(swigCPtr);
    return ret;
  }

  public void set_rprop_delta_max(float rprop_delta_max) {
    SwigFannPINVOKE.neural_net_set_rprop_delta_max(swigCPtr, rprop_delta_max);
  }

  public float get_sarprop_weight_decay_shift() {
    float ret = SwigFannPINVOKE.neural_net_get_sarprop_weight_decay_shift(swigCPtr);
    return ret;
  }

  public void set_sarprop_weight_decay_shift(float sarprop_weight_decay_shift) {
    SwigFannPINVOKE.neural_net_set_sarprop_weight_decay_shift(swigCPtr, sarprop_weight_decay_shift);
  }

  public float get_sarprop_step_error_threshold_factor() {
    float ret = SwigFannPINVOKE.neural_net_get_sarprop_step_error_threshold_factor(swigCPtr);
    return ret;
  }

  public void set_sarprop_step_error_threshold_factor(float sarprop_step_error_threshold_factor) {
    SwigFannPINVOKE.neural_net_set_sarprop_step_error_threshold_factor(swigCPtr, sarprop_step_error_threshold_factor);
  }

  public float get_sarprop_step_error_shift() {
    float ret = SwigFannPINVOKE.neural_net_get_sarprop_step_error_shift(swigCPtr);
    return ret;
  }

  public void set_sarprop_step_error_shift(float sarprop_step_error_shift) {
    SwigFannPINVOKE.neural_net_set_sarprop_step_error_shift(swigCPtr, sarprop_step_error_shift);
  }

  public float get_sarprop_temperature() {
    float ret = SwigFannPINVOKE.neural_net_get_sarprop_temperature(swigCPtr);
    return ret;
  }

  public void set_sarprop_temperature(float sarprop_temperature) {
    SwigFannPINVOKE.neural_net_set_sarprop_temperature(swigCPtr, sarprop_temperature);
  }

  public uint get_num_input() {
    uint ret = SwigFannPINVOKE.neural_net_get_num_input(swigCPtr);
    return ret;
  }

  public uint get_num_output() {
    uint ret = SwigFannPINVOKE.neural_net_get_num_output(swigCPtr);
    return ret;
  }

  public uint get_total_neurons() {
    uint ret = SwigFannPINVOKE.neural_net_get_total_neurons(swigCPtr);
    return ret;
  }

  public uint get_total_connections() {
    uint ret = SwigFannPINVOKE.neural_net_get_total_connections(swigCPtr);
    return ret;
  }

  public network_type_enum get_network_type() {
    network_type_enum ret = (network_type_enum)SwigFannPINVOKE.neural_net_get_network_type(swigCPtr);
    return ret;
  }

  public float get_connection_rate() {
    float ret = SwigFannPINVOKE.neural_net_get_connection_rate(swigCPtr);
    return ret;
  }

  public uint get_num_layers() {
    uint ret = SwigFannPINVOKE.neural_net_get_num_layers(swigCPtr);
    return ret;
  }

  public void get_layer_array(SWIGTYPE_p_unsigned_int layers) {
    SwigFannPINVOKE.neural_net_get_layer_array(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(layers));
  }

  public void get_bias_array(SWIGTYPE_p_unsigned_int bias) {
    SwigFannPINVOKE.neural_net_get_bias_array(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(bias));
  }

  public void get_connection_array(SWIGTYPE_p_connection connections) {
    SwigFannPINVOKE.neural_net_get_connection_array(swigCPtr, SWIGTYPE_p_connection.getCPtr(connections));
  }

  public void set_weight_array(SWIGTYPE_p_connection connections, uint num_connections) {
    SwigFannPINVOKE.neural_net_set_weight_array(swigCPtr, SWIGTYPE_p_connection.getCPtr(connections), num_connections);
  }

  public void set_weight(uint from_neuron, uint to_neuron, float weight) {
    SwigFannPINVOKE.neural_net_set_weight(swigCPtr, from_neuron, to_neuron, weight);
  }

  public float get_learning_momentum() {
    float ret = SwigFannPINVOKE.neural_net_get_learning_momentum(swigCPtr);
    return ret;
  }

  public void set_learning_momentum(float learning_momentum) {
    SwigFannPINVOKE.neural_net_set_learning_momentum(swigCPtr, learning_momentum);
  }

  public stop_function_enum get_train_stop_function() {
    stop_function_enum ret = (stop_function_enum)SwigFannPINVOKE.neural_net_get_train_stop_function(swigCPtr);
    return ret;
  }

  public void set_train_stop_function(stop_function_enum train_stop_function) {
    SwigFannPINVOKE.neural_net_set_train_stop_function(swigCPtr, (int)train_stop_function);
  }

  public float get_bit_fail_limit() {
    float ret = SwigFannPINVOKE.neural_net_get_bit_fail_limit(swigCPtr);
    return ret;
  }

  public void set_bit_fail_limit(float bit_fail_limit) {
    SwigFannPINVOKE.neural_net_set_bit_fail_limit(swigCPtr, bit_fail_limit);
  }

  public uint get_bit_fail() {
    uint ret = SwigFannPINVOKE.neural_net_get_bit_fail(swigCPtr);
    return ret;
  }

  public void cascadetrain_on_data(training_data data, uint max_neurons, uint neurons_between_reports, float desired_error) {
    SwigFannPINVOKE.neural_net_cascadetrain_on_data(swigCPtr, training_data.getCPtr(data), max_neurons, neurons_between_reports, desired_error);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public void cascadetrain_on_file(string filename, uint max_neurons, uint neurons_between_reports, float desired_error) {
    SwigFannPINVOKE.neural_net_cascadetrain_on_file(swigCPtr, filename, max_neurons, neurons_between_reports, desired_error);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public float get_cascade_output_change_fraction() {
    float ret = SwigFannPINVOKE.neural_net_get_cascade_output_change_fraction(swigCPtr);
    return ret;
  }

  public void set_cascade_output_change_fraction(float cascade_output_change_fraction) {
    SwigFannPINVOKE.neural_net_set_cascade_output_change_fraction(swigCPtr, cascade_output_change_fraction);
  }

  public uint get_cascade_output_stagnation_epochs() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_output_stagnation_epochs(swigCPtr);
    return ret;
  }

  public void set_cascade_output_stagnation_epochs(uint cascade_output_stagnation_epochs) {
    SwigFannPINVOKE.neural_net_set_cascade_output_stagnation_epochs(swigCPtr, cascade_output_stagnation_epochs);
  }

  public float get_cascade_candidate_change_fraction() {
    float ret = SwigFannPINVOKE.neural_net_get_cascade_candidate_change_fraction(swigCPtr);
    return ret;
  }

  public void set_cascade_candidate_change_fraction(float cascade_candidate_change_fraction) {
    SwigFannPINVOKE.neural_net_set_cascade_candidate_change_fraction(swigCPtr, cascade_candidate_change_fraction);
  }

  public uint get_cascade_candidate_stagnation_epochs() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_candidate_stagnation_epochs(swigCPtr);
    return ret;
  }

  public void set_cascade_candidate_stagnation_epochs(uint cascade_candidate_stagnation_epochs) {
    SwigFannPINVOKE.neural_net_set_cascade_candidate_stagnation_epochs(swigCPtr, cascade_candidate_stagnation_epochs);
  }

  public float get_cascade_weight_multiplier() {
    float ret = SwigFannPINVOKE.neural_net_get_cascade_weight_multiplier(swigCPtr);
    return ret;
  }

  public void set_cascade_weight_multiplier(float cascade_weight_multiplier) {
    SwigFannPINVOKE.neural_net_set_cascade_weight_multiplier(swigCPtr, cascade_weight_multiplier);
  }

  public float get_cascade_candidate_limit() {
    float ret = SwigFannPINVOKE.neural_net_get_cascade_candidate_limit(swigCPtr);
    return ret;
  }

  public void set_cascade_candidate_limit(float cascade_candidate_limit) {
    SwigFannPINVOKE.neural_net_set_cascade_candidate_limit(swigCPtr, cascade_candidate_limit);
  }

  public uint get_cascade_max_out_epochs() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_max_out_epochs(swigCPtr);
    return ret;
  }

  public void set_cascade_max_out_epochs(uint cascade_max_out_epochs) {
    SwigFannPINVOKE.neural_net_set_cascade_max_out_epochs(swigCPtr, cascade_max_out_epochs);
  }

  public uint get_cascade_max_cand_epochs() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_max_cand_epochs(swigCPtr);
    return ret;
  }

  public void set_cascade_max_cand_epochs(uint cascade_max_cand_epochs) {
    SwigFannPINVOKE.neural_net_set_cascade_max_cand_epochs(swigCPtr, cascade_max_cand_epochs);
  }

  public uint get_cascade_num_candidates() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_num_candidates(swigCPtr);
    return ret;
  }

  public uint get_cascade_activation_functions_count() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_activation_functions_count(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_FANN__activation_function_enum get_cascade_activation_functions() {
    global::System.IntPtr cPtr = SwigFannPINVOKE.neural_net_get_cascade_activation_functions(swigCPtr);
    SWIGTYPE_p_FANN__activation_function_enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FANN__activation_function_enum(cPtr, false);
    return ret;
  }

  public void set_cascade_activation_functions(SWIGTYPE_p_FANN__activation_function_enum cascade_activation_functions, uint cascade_activation_functions_count) {
    SwigFannPINVOKE.neural_net_set_cascade_activation_functions(swigCPtr, SWIGTYPE_p_FANN__activation_function_enum.getCPtr(cascade_activation_functions), cascade_activation_functions_count);
  }

  public uint get_cascade_activation_steepnesses_count() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_activation_steepnesses_count(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_float get_cascade_activation_steepnesses() {
    global::System.IntPtr cPtr = SwigFannPINVOKE.neural_net_get_cascade_activation_steepnesses(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public void set_cascade_activation_steepnesses(SWIGTYPE_p_float cascade_activation_steepnesses, uint cascade_activation_steepnesses_count) {
    SwigFannPINVOKE.neural_net_set_cascade_activation_steepnesses(swigCPtr, SWIGTYPE_p_float.getCPtr(cascade_activation_steepnesses), cascade_activation_steepnesses_count);
  }

  public uint get_cascade_num_candidate_groups() {
    uint ret = SwigFannPINVOKE.neural_net_get_cascade_num_candidate_groups(swigCPtr);
    return ret;
  }

  public void set_cascade_num_candidate_groups(uint cascade_num_candidate_groups) {
    SwigFannPINVOKE.neural_net_set_cascade_num_candidate_groups(swigCPtr, cascade_num_candidate_groups);
  }

  public void scale_train(training_data data) {
    SwigFannPINVOKE.neural_net_scale_train(swigCPtr, training_data.getCPtr(data));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public void descale_train(training_data data) {
    SwigFannPINVOKE.neural_net_descale_train(swigCPtr, training_data.getCPtr(data));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool set_input_scaling_params(training_data data, float new_input_min, float new_input_max) {
    bool ret = SwigFannPINVOKE.neural_net_set_input_scaling_params(swigCPtr, training_data.getCPtr(data), new_input_min, new_input_max);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_output_scaling_params(training_data data, float new_output_min, float new_output_max) {
    bool ret = SwigFannPINVOKE.neural_net_set_output_scaling_params(swigCPtr, training_data.getCPtr(data), new_output_min, new_output_max);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_scaling_params(training_data data, float new_input_min, float new_input_max, float new_output_min, float new_output_max) {
    bool ret = SwigFannPINVOKE.neural_net_set_scaling_params(swigCPtr, training_data.getCPtr(data), new_input_min, new_input_max, new_output_min, new_output_max);
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool clear_scaling_params() {
    bool ret = SwigFannPINVOKE.neural_net_clear_scaling_params(swigCPtr);
    return ret;
  }

  public void scale_input(SWIGTYPE_p_float input_vector) {
    SwigFannPINVOKE.neural_net_scale_input(swigCPtr, SWIGTYPE_p_float.getCPtr(input_vector));
  }

  public void scale_output(SWIGTYPE_p_float output_vector) {
    SwigFannPINVOKE.neural_net_scale_output(swigCPtr, SWIGTYPE_p_float.getCPtr(output_vector));
  }

  public void descale_input(SWIGTYPE_p_float input_vector) {
    SwigFannPINVOKE.neural_net_descale_input(swigCPtr, SWIGTYPE_p_float.getCPtr(input_vector));
  }

  public void descale_output(SWIGTYPE_p_float output_vector) {
    SwigFannPINVOKE.neural_net_descale_output(swigCPtr, SWIGTYPE_p_float.getCPtr(output_vector));
  }

  public void set_error_log(SWIGTYPE_p_FILE log_file) {
    SwigFannPINVOKE.neural_net_set_error_log(swigCPtr, SWIGTYPE_p_FILE.getCPtr(log_file));
  }

  public uint get_errno() {
    uint ret = SwigFannPINVOKE.neural_net_get_errno(swigCPtr);
    return ret;
  }

  public void reset_errno() {
    SwigFannPINVOKE.neural_net_reset_errno(swigCPtr);
  }

  public void reset_errstr() {
    SwigFannPINVOKE.neural_net_reset_errstr(swigCPtr);
  }

  public string get_errstr() {
    string ret = SwigFannPINVOKE.neural_net_get_errstr(swigCPtr);
    return ret;
  }

  public void print_error() {
    SwigFannPINVOKE.neural_net_print_error(swigCPtr);
  }

  public void disable_seed_rand() {
    SwigFannPINVOKE.neural_net_disable_seed_rand(swigCPtr);
  }

  public void enable_seed_rand() {
    SwigFannPINVOKE.neural_net_enable_seed_rand(swigCPtr);
  }

}

}
