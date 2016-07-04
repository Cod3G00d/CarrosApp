(function() {
	'use strict';

	/**
	* @ngdoc function
	* @name app.controller:fabricantesCtrl
	* @description
	* # fabricantesCtrl
	* Controller of the app
	*/

  	angular
		.module('fabricantes')
		.controller('FabricantesCtrl', Fabricantes);

		Fabricantes.$inject = [];

		/*
		* recommend
		* Using function declarations
		* and bindable members up top.
		*/

		function Fabricantes() {
			/*jshint validthis: true */
			var vm = this;

		}

})();
