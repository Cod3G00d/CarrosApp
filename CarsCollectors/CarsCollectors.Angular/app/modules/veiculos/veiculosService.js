(function() {
	'use strict';

	/**
	 * @ngdoc function
	 * @name app.service:veiculosService
	 * @description
	 * # veiculosService
	 * Service of the app
	 */

  	angular
		.module('veiculos')
		.factory('VeiculosService', Veiculos);
		// Inject your dependencies as .$inject = ['$http', 'someSevide'];
		// function Name ($http, someSevide) {...}

		Veiculos.$inject = ['$http'];

		function Veiculos ($http) {

		}

})();
