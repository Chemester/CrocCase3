<template>
	<div>
		<v-app-bar app flat>
			<div class="d-flex align-center">
				<v-img
					alt="croc-name"
					contain
					min-width="100"
					src="..\assets\croc-name.svg"
					width="100"
				/>
			</div>
			
			<v-toolbar-title class="p_name">
				{{ title }}
			</v-toolbar-title>
			
			<v-spacer></v-spacer>
			
			<newproject></newproject>
			
			<editproject></editproject>
			
			<search></search>
		</v-app-bar>
		
	</div>
</template>

<script>
import Vue from "vue";
import search from "./search";
import newproject from "./createProj";
import editproject from "./editProj";

export default Vue.component("v-header", {
	components: {
		search,
		newproject,
		editproject,
	},
	props: ["title"],
	data: () => ({
		"--castSize": null,
		search: false,
	}),
	computed: {
		//динамически изменяет размер шрифта
		"--castSize": function () {
			if (this.title.length > 74) {
				return 10;
			} else if (this.title.length > 148) {
				return 5;
			}
			return 20;
		},
	},
});
</script>

<style lang="scss" scoped>
@font-face {
	font-family: "CrocBold";
	src: url("../fonts/CrocBold.eot");
	src: url("../fonts/CrocBold.eot") format("embedded-opentype"),
	url("../fonts/CrocBold.svg#CrocBold") format("svg"),
	url("../fonts/CrocBold.ttf") format("truetype");
}

.v-btn {
	margin: 5px;
}

.p_name {
	margin: 30px;
	max-height: 40px;
	max-width: 800px;
	white-space: pre-wrap;
	font-size: 20px;
	font-size: calc(var(--castSize) * 1px);
}

.v-toolbar {
	font-family: CrocBold;
}

</style>
