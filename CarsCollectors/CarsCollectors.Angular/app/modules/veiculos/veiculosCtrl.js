(function() {
	'use strict';

	/**
	* @ngdoc function
	* @name app.controller:veiculosCtrl
	* @description
	* # veiculosCtrl
	* Controller of the app
	*/

  	angular
		.module('veiculos')
		.controller('VeiculosCtrl', Veiculos);

		Veiculos.$inject = [];

		/*
		* recommend
		* Using function declarations
		* and bindable members up top.
		*/

		function Veiculos() {
			/*jshint validthis: true */
			var vm = this;

		}

})();
