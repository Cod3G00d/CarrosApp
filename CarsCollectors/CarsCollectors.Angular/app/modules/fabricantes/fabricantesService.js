(function() {
	'use strict';

	/**
	 * @ngdoc function
	 * @name app.service:fabricantesService
	 * @description
	 * # fabricantesService
	 * Service of the app
	 */

  	angular
		.module('fabricantes')
		.factory('FabricantesService', Fabricantes);
		// Inject your dependencies as .$inject = ['$http', 'someSevide'];
		// function Name ($http, someSevide) {...}

		Fabricantes.$inject = ['$resource'];

		function Fabricantes($resource) {
		    return $resource('http://localhost:51101' + '/api/Fabricantes/:Id');
		}

})();
